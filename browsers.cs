using System;
using System.Windows.Forms;

namespace Winstaller
{
    public partial class browsers : Form
    {
        public browsers()
        {
            InitializeComponent();
            CenterToScreen();
            chrome.Click += chrome_Click;
            thorium.Click += thorium_Click;
            brave.Click += brave_Click;
            librewolf.Click += librewolf_Click;
            ungoogledchromium.Click += ungoogledchromium_Click;
        }

        private void chrome_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://www.google.com/chrome/next-steps.html?statcb=1&installdataindex=empty&defaultbrowser=0#");
        }

        private void thorium_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://github.com/Alex313031/Thorium-Win/releases/download/M120.0.6099.235/thorium_AVX2_mini_installer.exe");
        }

        private void brave_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://github.com/brave/brave-browser/releases/download/v1.64.56/BraveBrowserNightlySetup.exe");
        }

        private void librewolf_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://gitlab.com/api/v4/projects/44042130/packages/generic/librewolf/122.0-2/librewolf-122.0-2-windows-x86_64-setup.exe");
        }

        private void ungoogledchromium_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://github.com/ungoogled-software/ungoogled-chromium-windows/releases/download/120.0.6099.199-1.1/ungoogled-chromium_120.0.6099.199-1.1_installer_x64.exe");
        }

        private void DownloadProgram(string downloadUrl)
        {
            System.Diagnostics.Process.Start(downloadUrl);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Categories categoriesForm = new Categories();
            categoriesForm.Show();
            Hide();
        }
    }
}
