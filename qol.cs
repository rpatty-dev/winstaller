using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Winstaller
{
    public partial class qol : Form
    {
        public qol()
        {
            InitializeComponent();
            CenterToScreen();
            superf4.Click += superf4_Click;
            eartrumpet.Click += eartrumpet_Click;
            vibrancegui.Click += vibrancegui_Click;
            nvidiabroadcast.Click += nvidiabroadcast_Click;
            medal.Click += medal_Click;
            sevenzip.Click += sevenzip_Click;
            everythingalpha.Click += everythingalpha_Click;
        }

        private void superf4_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://github.com/stefansundin/superf4/releases/download/v1.4/SuperF4-1.4.exe");
        }

        private void eartrumpet_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://install.eartrumpet.app/dev/EarTrumpet.Package.appinstaller");
        }

        private void vibrancegui_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://vibrancegui.com/vibrance/version1");
        }

        private void nvidiabroadcast_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://international.download.nvidia.com/Windows/broadcast/1.4.0.29/NVIDIA_Broadcast_v1.4.0.29.exe");
        }

        private void medal_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://install.medal.tv/?uid=216609404&guest=1&ref=0");
        }

        private void sevenzip_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://github.com/mcmilk/7-Zip-zstd/releases/download/v22.01-v1.5.5-R3/7z22.01-zstd-x64.exe");
        }

        private void everythingalpha_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://www.voidtools.com/Everything-1.5.0.1367a.x64-Setup.exe");
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
