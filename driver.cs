using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Winstaller
{
    public partial class driver : Form
    {
        public driver()
        {
            InitializeComponent();
            CenterToScreen();
            nvcleaninstall.Click += nvcleaninstall_Click;
            amdchipset.Click += amdchipset_Click;
            xboxadapter.Click += xboxadapter_Click;
        }

        private void nvcleaninstall_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://nl1-dl.techpowerup.com/files/nFp62dxFZytgPfiQVIm79Q/1707479323/NVCleanstall_1.16.0.exe");
        }

        private void amdchipset_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://www.amd.com/en/support/chipsets/amd-socket-am4/b450");
        }

        private void xboxadapter_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://download1503.mediafire.com/4g1209ch72sgmNBhW0ylThms5BTFaWKe5fYScRyjHocjU_FjGglxlBSTsU9moBnXdFwTiuvBoaJTaiLCL0saBEug_8UNlDKFWs6O5WnmQaj0pb18yghCr9RhY8IAKa7VaQt6l_yG_2NSg-mec8xqNMlQLNFccDd17eJbyAw-Bw/eghr6c1516inp0b/Xbox+Drivers.7z");
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
