using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Winstaller
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            enterbtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, enterbtn.Width, enterbtn.Height, 20, 20));
            installchoco.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, installchoco.Width, installchoco.Height, 20, 20));
            CenterToScreen();

        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void enterbtn_Click(object sender, EventArgs e)
        {
            Categories categoriesForm = new Categories();
            categoriesForm.Show();
            this.Hide();
        }

        private void installchoco_Click(object sender, EventArgs e)
        {
            InstallChocolatey();
        }

        private void InstallChocolatey()
        {
            string command = @"cmd.exe";
            string arguments = @"/c @powershell -NoProfile -ExecutionPolicy Bypass -Command ""iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))"" && SET ""PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin""";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = command;
            startInfo.Arguments = arguments;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.Verb = "runas"; // Run as admin

            using (Process process = Process.Start(startInfo))
            {
                process.WaitForExit();
            }

            MessageBox.Show("Chocolatey has been installed successfully!", "Installation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
