using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Winstaller
{
    public partial class pc : Form
    {
        public pc()
        {
            InitializeComponent();
            CenterToScreen();
            nzxtcam.Click += nzxtcam_Click;
            msiafterburner.Click += msiafterburner_Click;
            icue.Click += icue_Click;
            speccy.Click += speccy_Click;
        }

        private void nzxtcam_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://nzxt-app.nzxt.com/NZXT-CAM-Setup.exe");
        }

        private void msiafterburner_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://download.msi.com/uti_exe/vga/MSIAfterburnerSetup.zip?__token__=exp=1707564817~acl=/*~hmac=17a25548bb3f8564baa3e76ce32abb3917ddcb0f8f03b3796e5c24a1c87fddc3");
        }

        private void icue_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://www3.corsair.com/software/CUE_V5/public/modules/windows/installer/Install%20iCUE.exe");
        }

        private void speccy_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://www.cpuid.com/downloads/hwmonitor/hwmonitor_1.52.exe");
        }

        private void DownloadProgram(string downloadUrl)
        {
            Process.Start(downloadUrl);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Categories categoriesForm = new Categories();
            categoriesForm.Show();
            this.Hide();
        }
    }
}
