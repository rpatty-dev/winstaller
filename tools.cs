using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Winstaller
{
    public partial class tools : Form
    {
        public tools()
        {
            InitializeComponent();
            CenterToScreen();

            // subscribed because buttons were not workin
            python.Click += python_Click;
            git.Click += git_Click;
            node.Click += node_Click;
            nmap.Click += nmap_Click;
        }


        private void python_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://www.python.org/ftp/python/3.12.2/python-3.12.2-amd64.exe");
        }

        private void git_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://github.com/git-for-windows/git/releases/download/v2.43.0.windows.1/Git-2.43.0-64-bit.exe");
        }

        private void node_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://nodejs.org/dist/v16.14.0/node-v16.14.0-x64.msi");
        }

        private void nmap_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://nmap.org/dist/nmap-7.94-setup.exe");
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
