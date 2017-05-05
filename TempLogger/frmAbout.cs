using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TempLogger
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            lblAbout.Text = fvi.FileVersion;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
