using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using RASW;

namespace TempLogger
{
    public partial class Form1 : Form
    {
        int captureCount = 0;

        AppSettings appSet = new AppSettings(Path.Combine(Directory.GetCurrentDirectory(),"TempLogger.xml"));

        private int readTemperatures()
        {
            TcpClient tcpClient = new TcpClient();               

            try
            {
                // Attempt the connection
                tcpClient.Connect(ipAddressTextBox.Text, Convert.ToInt32(portTextBox.Text));

                if (tcpClient.Connected)
                {
                    // Create a network stream object
                    NetworkStream netStream = tcpClient.GetStream();

                    // If we can read and write to the stream then do so
                    if (netStream.CanWrite && netStream.CanRead)
                    {
                        // if there is a password then we need to encode it first convert the password to a byte array
                        byte[] password_bytes = Encoding.ASCII.GetBytes("none:" + passwordTextBox.Text);
                        string pass = Convert.ToBase64String(password_bytes);

                        // Create the command to send to the temperature module
                        byte[] sendBytes = Encoding.ASCII.GetBytes("GET /state.xml HTTP/1.1" + Environment.NewLine + "Authorization: Basic " + pass + Environment.NewLine + Environment.NewLine);
                        netStream.Write(sendBytes, 0, sendBytes.Length);

                        // Get the response from the temperature module
                        byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                        netStream.Read(bytes, 0, tcpClient.ReceiveBufferSize);

                        // Parse the response and update the temperature text boxes
                        string returndata = Encoding.ASCII.GetString(bytes);

                        char[] splitters = { '<', '>' };

                        string[] strs = returndata.Split(splitters);

                        // go through all the strings and extract the temperatures
                        int sensorNumber = 1;
                        string unitsCompareStr = "units";
                        string sensorCompareStr = "sensor" + sensorNumber.ToString() + "temp";
                        
                        for (int i = 0; i < strs.Length; i++)
                        {
                            if (strs[i] == unitsCompareStr)
                            {
                               lblCF1.Text = strs[i + 1];
                               lblCF2.Text = strs[i + 1];
                               lblCF3.Text = strs[i + 1];
                               lblCF4.Text = strs[i + 1];
                            }

                            if (strs[i] == sensorCompareStr)
                            {
                                // the next string is the current temperature for this sensor
                                switch (sensorNumber)
                                {
                                    case 1:
                                        sensor1TextBox.Text = strs[i + 1];
                                        break;
                                    case 2:
                                        sensor2TextBox.Text = strs[i + 1];
                                        break;
                                    case 3:
                                        sensor3TextBox.Text = strs[i + 1];
                                        break;
                                    case 4:
                                        sensor4TextBox.Text = strs[i + 1];
                                        break;
                                }
                                
                                // move to the next sensor
                                sensorNumber++;
                                i++;
                                sensorCompareStr = "sensor" + sensorNumber.ToString() + "temp";
                            }
                                                       
                        }

                    }

                    // Close the connection
                    tcpClient.Close();
                    captureCount++;
                    lblCaptureCount.Text = captureCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem communicting with the unit." + Environment.NewLine + "Message received: " + ex.Message + Environment.NewLine +
                    "Make sure to use a valid IP Address and Port Number as well as a Password if it is required.", "Information", MessageBoxButtons.OK);
                return 3;
            }
            return 3;
        }

        private void logToFile()
        {
            readTemperatures();

            if (logFilenameTextBox.Text == "")
                return;

            StreamWriter sw;

            if (!File.Exists(logFilenameTextBox.Text))
            {
                sw = File.AppendText(logFilenameTextBox.Text);// create a new file

                // insert the header
                sw.WriteLine("Module IP: " + ipAddressTextBox.Text + "||||||");
                sw.WriteLine("Port: " + portTextBox.Text + "||||||");

                sw.Write("DD/MM/YYYY HH:MM:SS|Units|" + appSet.getValue("Sensor1Name") + "|" + appSet.getValue("Sensor2Name") + "|" + appSet.getValue("Sensor3Name") + "|" + appSet.getValue("Sensor4Name") + "|" + Environment.NewLine);
                sw.Write(Environment.NewLine);
            }
            else
            {
                // open and append to the file
                sw = File.AppendText(logFilenameTextBox.Text);
            }

            sw.Write(DateTime.Now.ToString("G") + "|" + lblCF1.Text + "|" + sensor1TextBox.Text + "|" + sensor2TextBox.Text + "|" + sensor3TextBox.Text + "|" + sensor4TextBox.Text + Environment.NewLine);
            sw.Close();
        }

        private void startLogging()
        {
            logTimer.Interval = (int)periodUpDownBox.Value * 1000;        // set the tick value for the log timer
            logTimer.Enabled = true;
            logTimer.Start();
        }

        private void stopLogging()
        {
            // stop both timers
            logTimer.Stop();
        }

        // this function reads the contents of all the text fields to a file accept for the password
        private void restoreState()
        {
            if (appSet.getValue("Interval").Length != 0)
            {
                periodUpDownBox.Value = Convert.ToInt32(appSet.getValue("Interval"));
            }
                       
            ipAddressTextBox.Text = appSet.getValue("IpAddress");
            portTextBox.Text = appSet.getValue("Port");

            byte[] decodedPassword = Convert.FromBase64String(appSet.getValue("password"));
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            passwordTextBox.Text = Convert.ToString(enc.GetString(decodedPassword));

            logFilenameTextBox.Text = appSet.getValue("LogFileName");

            string str = appSet.getValue("");
            if (str != "")
               if (str == "1") startLogging(); else stopLogging();

            txtSensor1Name.Text = appSet.getValue("Sensor1Name").Trim();
            txtSensor2Name.Text = appSet.getValue("Sensor2Name").Trim();
            txtSensor3Name.Text = appSet.getValue("Sensor3Name").Trim();
            txtSensor4Name.Text = appSet.getValue("Sensor4Name").Trim();

            if (txtSensor1Name.Text.Length == 0) txtSensor1Name.Text = "Sensor 1";
            if (txtSensor2Name.Text.Length == 0) txtSensor2Name.Text = "Sensor 2";
            if (txtSensor3Name.Text.Length == 0) txtSensor3Name.Text = "Sensor 3";
            if (txtSensor4Name.Text.Length == 0) txtSensor4Name.Text = "Sensor 4";
        }

        // this function writes the contents of all the text fields to a file accept for the password
        private void saveState()
        {
            appSet.setValue("Interval", periodUpDownBox.Value.ToString());
            appSet.setValue("IpAddress", ipAddressTextBox.Text);
            appSet.setValue("Port", portTextBox.Text);

            byte[] password_bytes = Encoding.ASCII.GetBytes(passwordTextBox.Text);
            appSet.setValue("password", Convert.ToBase64String(password_bytes));
            appSet.setValue("LogFileName", logFilenameTextBox.Text);

            // save the logging state ON or OFF
            if (logTimer.Enabled == true)
                appSet.setValue("LoggingState", "1");
            else
                appSet.setValue("LoggingState", "0");

            appSet.setValue("Sensor1Name", txtSensor1Name.Text.Trim());
            appSet.setValue("Sensor2Name", txtSensor2Name.Text.Trim());
            appSet.setValue("Sensor3Name", txtSensor3Name.Text.Trim());
            appSet.setValue("Sensor4Name", txtSensor4Name.Text.Trim());
        }

        public Form1()
        {
            InitializeComponent();

            stopLogging();       
            restoreState();    // load the user settings from the configuration file     
        }

        private void saveCurrentSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveState();    // save the user settings
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveState();
            stopLogging();
            this.Dispose();
        }

        private void specifyLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // let them choose a template file
            // get the file to open
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Title = "Save Log File...";
            saveDlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            saveDlg.FilterIndex = 2;
            saveDlg.RestoreDirectory = true;

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                logFilenameTextBox.Text = saveDlg.FileName;
                if (!logFilenameTextBox.Text.EndsWith(".log"))
                {
                    logFilenameTextBox.Text += ".log";
                }
                    appSet.setValue("LogfilePath", logFilenameTextBox.Text);
            }
        }

        private void logTimer_Tick(object sender, EventArgs e)
        {
           logToFile();
        }

        private void loggingOffButton_Click(object sender, EventArgs e)
        {
            stopLogging();
            loggingOnButton.Enabled = true;
            loggingOffButton.Enabled = false;
            lblRunningStopped.Text = "STOPPED";
        }

        private void loggingOnButton_Click(object sender, EventArgs e)
        {
            string fullName = logFilenameTextBox.Text.Trim();
            try
            {
                if (File.Exists(fullName))
                {
                    string copyPathFull = Path.GetDirectoryName(fullName);
                    string fileNameOnly = Path.GetFileNameWithoutExtension(fullName);
                    string backupName = fileNameOnly + "_Previous.log";

                    File.Copy(logFilenameTextBox.Text.Trim(), Path.Combine(copyPathFull, backupName), true);
                    File.Delete(fullName);
                }
            }
            catch {}

            saveState();
            startLogging();
            lblRunningStopped.Text = "RUNNING";
            loggingOnButton.Enabled = false;
            loggingOffButton.Enabled = true;
            loggingOffButton.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString("00");
            string day = DateTime.Now.Day.ToString();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            logFilenameTextBox.Text = desktopPath + @"\Temperature_" + year + month + day + ".log";
            restoreState();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLogFilePath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString("00");
            string day = DateTime.Now.Day.ToString();
           
            if (result == DialogResult.OK)
            {
                logFilenameTextBox.Text =  folderBrowserDialog1.SelectedPath + @"\Temperature_" + year + month + day + ".log";
                appSet.setValue("LogfilePath", logFilenameTextBox.Text.Trim());
            }
        }

        private void periodUpDownBox_ValueChanged(object sender, EventArgs e)
        {
            logTimer.Interval = (int)periodUpDownBox.Value;
        }

        private void txtSensor1Name_Leave(object sender, EventArgs e)
        {
            appSet.setValue("Sensor1Name", txtSensor1Name.Text);
            appSet.setValue("Sensor2Name", txtSensor2Name.Text);
            appSet.setValue("Sensor3Name", txtSensor3Name.Text);
            appSet.setValue("Sensor4Name", txtSensor4Name.Text);
        }

        private void initialLogTimer_Tick(object sender, EventArgs e)
        {
            //    // get the current time
            //    dt = DateTime.Now;
            //    next_dt = dt.AddMinutes((double)periodUpDownBox.Value);
            //    initialLogTimer.Enabled = false;
            //    logTimer.Enabled = true;
            //    logToFile();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.ShowDialog();
        }
    }
}