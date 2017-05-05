namespace TempLogger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specifyLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodUpDownBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRunningStopped = new System.Windows.Forms.Label();
            this.lblCaptureCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loggingOffButton = new System.Windows.Forms.Button();
            this.loggingOnButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCF4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCF3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCF2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCF1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSensor4Name = new System.Windows.Forms.TextBox();
            this.txtSensor3Name = new System.Windows.Forms.TextBox();
            this.txtSensor2Name = new System.Windows.Forms.TextBox();
            this.txtSensor1Name = new System.Windows.Forms.TextBox();
            this.sensor4TextBox = new System.Windows.Forms.TextBox();
            this.sensor3TextBox = new System.Windows.Forms.TextBox();
            this.sensor2TextBox = new System.Windows.Forms.TextBox();
            this.sensor1TextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLogFilePath = new System.Windows.Forms.Button();
            this.logFilenameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.logTimer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodUpDownBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specifyLogFileToolStripMenuItem,
            this.saveCurrentSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // specifyLogFileToolStripMenuItem
            // 
            this.specifyLogFileToolStripMenuItem.Name = "specifyLogFileToolStripMenuItem";
            this.specifyLogFileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.specifyLogFileToolStripMenuItem.Text = "Setup Log File";
            this.specifyLogFileToolStripMenuItem.Click += new System.EventHandler(this.specifyLogFileToolStripMenuItem_Click);
            // 
            // saveCurrentSettingsToolStripMenuItem
            // 
            this.saveCurrentSettingsToolStripMenuItem.Name = "saveCurrentSettingsToolStripMenuItem";
            this.saveCurrentSettingsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveCurrentSettingsToolStripMenuItem.Text = "Save Current Settings";
            this.saveCurrentSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // periodUpDownBox
            // 
            this.periodUpDownBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.periodUpDownBox.Location = new System.Drawing.Point(76, 27);
            this.periodUpDownBox.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.periodUpDownBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.periodUpDownBox.Name = "periodUpDownBox";
            this.periodUpDownBox.Size = new System.Drawing.Size(60, 20);
            this.periodUpDownBox.TabIndex = 0;
            this.periodUpDownBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.periodUpDownBox.ValueChanged += new System.EventHandler(this.periodUpDownBox_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRunningStopped);
            this.groupBox1.Controls.Add(this.lblCaptureCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.periodUpDownBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Period (Seconds)";
            // 
            // lblRunningStopped
            // 
            this.lblRunningStopped.AutoSize = true;
            this.lblRunningStopped.ForeColor = System.Drawing.Color.Green;
            this.lblRunningStopped.Location = new System.Drawing.Point(175, 60);
            this.lblRunningStopped.Name = "lblRunningStopped";
            this.lblRunningStopped.Size = new System.Drawing.Size(22, 13);
            this.lblRunningStopped.TabIndex = 8;
            this.lblRunningStopped.Text = "- - -";
            // 
            // lblCaptureCount
            // 
            this.lblCaptureCount.AutoSize = true;
            this.lblCaptureCount.Location = new System.Drawing.Point(95, 60);
            this.lblCaptureCount.Name = "lblCaptureCount";
            this.lblCaptureCount.Size = new System.Drawing.Size(22, 13);
            this.lblCaptureCount.TabIndex = 7;
            this.lblCaptureCount.Text = "- - -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Capture Count:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Log Every:";
            // 
            // loggingOffButton
            // 
            this.loggingOffButton.Location = new System.Drawing.Point(424, 254);
            this.loggingOffButton.Name = "loggingOffButton";
            this.loggingOffButton.Size = new System.Drawing.Size(143, 32);
            this.loggingOffButton.TabIndex = 1;
            this.loggingOffButton.Text = "Stop Logging";
            this.loggingOffButton.UseVisualStyleBackColor = true;
            this.loggingOffButton.Click += new System.EventHandler(this.loggingOffButton_Click);
            // 
            // loggingOnButton
            // 
            this.loggingOnButton.Location = new System.Drawing.Point(424, 217);
            this.loggingOnButton.Name = "loggingOnButton";
            this.loggingOnButton.Size = new System.Drawing.Size(143, 32);
            this.loggingOnButton.TabIndex = 0;
            this.loggingOnButton.Text = "Start Logging";
            this.loggingOnButton.UseVisualStyleBackColor = true;
            this.loggingOnButton.Click += new System.EventHandler(this.loggingOnButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCF4);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblCF3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblCF2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblCF1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSensor4Name);
            this.groupBox2.Controls.Add(this.txtSensor3Name);
            this.groupBox2.Controls.Add(this.txtSensor2Name);
            this.groupBox2.Controls.Add(this.txtSensor1Name);
            this.groupBox2.Controls.Add(this.sensor4TextBox);
            this.groupBox2.Controls.Add(this.sensor3TextBox);
            this.groupBox2.Controls.Add(this.sensor2TextBox);
            this.groupBox2.Controls.Add(this.sensor1TextBox);
            this.groupBox2.Location = new System.Drawing.Point(269, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 178);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Last Sensor Readings";
            // 
            // lblCF4
            // 
            this.lblCF4.AutoSize = true;
            this.lblCF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCF4.Location = new System.Drawing.Point(260, 130);
            this.lblCF4.Name = "lblCF4";
            this.lblCF4.Size = new System.Drawing.Size(15, 15);
            this.lblCF4.TabIndex = 17;
            this.lblCF4.Text = "C";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(252, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "o";
            // 
            // lblCF3
            // 
            this.lblCF3.AutoSize = true;
            this.lblCF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCF3.Location = new System.Drawing.Point(261, 96);
            this.lblCF3.Name = "lblCF3";
            this.lblCF3.Size = new System.Drawing.Size(15, 15);
            this.lblCF3.TabIndex = 15;
            this.lblCF3.Text = "C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(253, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "o";
            // 
            // lblCF2
            // 
            this.lblCF2.AutoSize = true;
            this.lblCF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCF2.Location = new System.Drawing.Point(260, 63);
            this.lblCF2.Name = "lblCF2";
            this.lblCF2.Size = new System.Drawing.Size(15, 15);
            this.lblCF2.TabIndex = 13;
            this.lblCF2.Text = "C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "o";
            // 
            // lblCF1
            // 
            this.lblCF1.AutoSize = true;
            this.lblCF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCF1.Location = new System.Drawing.Point(261, 27);
            this.lblCF1.Name = "lblCF1";
            this.lblCF1.Size = new System.Drawing.Size(15, 15);
            this.lblCF1.TabIndex = 11;
            this.lblCF1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "o";
            // 
            // txtSensor4Name
            // 
            this.txtSensor4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensor4Name.Location = new System.Drawing.Point(22, 124);
            this.txtSensor4Name.Name = "txtSensor4Name";
            this.txtSensor4Name.Size = new System.Drawing.Size(165, 26);
            this.txtSensor4Name.TabIndex = 3;
            this.txtSensor4Name.Text = "Sensor 4";
            this.txtSensor4Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSensor4Name.Leave += new System.EventHandler(this.txtSensor1Name_Leave);
            // 
            // txtSensor3Name
            // 
            this.txtSensor3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensor3Name.Location = new System.Drawing.Point(22, 90);
            this.txtSensor3Name.Name = "txtSensor3Name";
            this.txtSensor3Name.Size = new System.Drawing.Size(165, 26);
            this.txtSensor3Name.TabIndex = 2;
            this.txtSensor3Name.Text = "Sensor 3";
            this.txtSensor3Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSensor3Name.Leave += new System.EventHandler(this.txtSensor1Name_Leave);
            // 
            // txtSensor2Name
            // 
            this.txtSensor2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensor2Name.Location = new System.Drawing.Point(22, 57);
            this.txtSensor2Name.Name = "txtSensor2Name";
            this.txtSensor2Name.Size = new System.Drawing.Size(165, 26);
            this.txtSensor2Name.TabIndex = 1;
            this.txtSensor2Name.Text = "Sensor 2";
            this.txtSensor2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSensor2Name.Leave += new System.EventHandler(this.txtSensor1Name_Leave);
            // 
            // txtSensor1Name
            // 
            this.txtSensor1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensor1Name.Location = new System.Drawing.Point(22, 24);
            this.txtSensor1Name.Name = "txtSensor1Name";
            this.txtSensor1Name.Size = new System.Drawing.Size(165, 26);
            this.txtSensor1Name.TabIndex = 0;
            this.txtSensor1Name.Text = "Sensor 1";
            this.txtSensor1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSensor1Name.Leave += new System.EventHandler(this.txtSensor1Name_Leave);
            // 
            // sensor4TextBox
            // 
            this.sensor4TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor4TextBox.Location = new System.Drawing.Point(194, 124);
            this.sensor4TextBox.Name = "sensor4TextBox";
            this.sensor4TextBox.Size = new System.Drawing.Size(52, 26);
            this.sensor4TextBox.TabIndex = 7;
            this.sensor4TextBox.TabStop = false;
            this.sensor4TextBox.Text = "xx.x";
            // 
            // sensor3TextBox
            // 
            this.sensor3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor3TextBox.Location = new System.Drawing.Point(193, 90);
            this.sensor3TextBox.Name = "sensor3TextBox";
            this.sensor3TextBox.Size = new System.Drawing.Size(53, 26);
            this.sensor3TextBox.TabIndex = 5;
            this.sensor3TextBox.TabStop = false;
            this.sensor3TextBox.Text = "xx.x";
            // 
            // sensor2TextBox
            // 
            this.sensor2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor2TextBox.Location = new System.Drawing.Point(192, 57);
            this.sensor2TextBox.Name = "sensor2TextBox";
            this.sensor2TextBox.Size = new System.Drawing.Size(54, 26);
            this.sensor2TextBox.TabIndex = 1;
            this.sensor2TextBox.TabStop = false;
            this.sensor2TextBox.Text = "xx.x";
            // 
            // sensor1TextBox
            // 
            this.sensor1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor1TextBox.Location = new System.Drawing.Point(193, 24);
            this.sensor1TextBox.Name = "sensor1TextBox";
            this.sensor1TextBox.Size = new System.Drawing.Size(53, 26);
            this.sensor1TextBox.TabIndex = 0;
            this.sensor1TextBox.TabStop = false;
            this.sensor1TextBox.Text = "xx.x";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLogFilePath);
            this.groupBox3.Controls.Add(this.logFilenameTextBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 64);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Log File";
            // 
            // btnLogFilePath
            // 
            this.btnLogFilePath.Location = new System.Drawing.Point(364, 25);
            this.btnLogFilePath.Name = "btnLogFilePath";
            this.btnLogFilePath.Size = new System.Drawing.Size(25, 20);
            this.btnLogFilePath.TabIndex = 9;
            this.btnLogFilePath.Text = "...";
            this.btnLogFilePath.UseVisualStyleBackColor = true;
            this.btnLogFilePath.Click += new System.EventHandler(this.btnLogFilePath_Click);
            // 
            // logFilenameTextBox
            // 
            this.logFilenameTextBox.Location = new System.Drawing.Point(8, 25);
            this.logFilenameTextBox.Name = "logFilenameTextBox";
            this.logFilenameTextBox.Size = new System.Drawing.Size(348, 20);
            this.logFilenameTextBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.passwordTextBox);
            this.groupBox4.Controls.Add(this.portTextBox);
            this.groupBox4.Controls.Add(this.ipAddressTextBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(10, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 117);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Temperature Module Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(99, 80);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(126, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "admin";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(99, 53);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(51, 20);
            this.portTextBox.TabIndex = 1;
            this.portTextBox.Text = "80";
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(99, 27);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(126, 20);
            this.ipAddressTextBox.TabIndex = 0;
            this.ipAddressTextBox.Text = "192.168.48.125";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Port:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "IP Address:";
            // 
            // logTimer
            // 
            this.logTimer.Interval = 60000;
            this.logTimer.Tick += new System.EventHandler(this.logTimer_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(424, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 342);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.loggingOnButton);
            this.Controls.Add(this.loggingOffButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CBW Temperature Logger...   V1.4 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodUpDownBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specifyLogFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown periodUpDownBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox sensor4TextBox;
        private System.Windows.Forms.TextBox sensor3TextBox;
        private System.Windows.Forms.TextBox sensor2TextBox;
        private System.Windows.Forms.TextBox sensor1TextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox logFilenameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentSettingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer logTimer;
        private System.Windows.Forms.Button loggingOffButton;
        private System.Windows.Forms.Button loggingOnButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogFilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSensor4Name;
        private System.Windows.Forms.TextBox txtSensor3Name;
        private System.Windows.Forms.TextBox txtSensor2Name;
        private System.Windows.Forms.TextBox txtSensor1Name;
        private System.Windows.Forms.Label lblCaptureCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRunningStopped;
        private System.Windows.Forms.Label lblCF4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCF3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCF2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCF1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

