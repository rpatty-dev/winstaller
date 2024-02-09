using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Winstaller
{
    public partial class social : Form
    {
        public social()
        {
            InitializeComponent();
            CenterToScreen();
            discord.Click += discord_Click;
            telegram.Click += telegram_Click;
        }

        private void discord_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x86");
        }

        private void telegram_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://telegram.org/dl/desktop/win");
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
