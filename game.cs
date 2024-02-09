using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Winstaller
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
            CenterToScreen();
            playnite.Click += playnite_Click;
            steam.Click += steam_Click;
            epicgameslauncher.Click += epicgameslauncher_Click;
            valorant.Click += valorant_Click;
        }

        private void playnite_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://playnite.link/download/PlayniteInstaller.exe");
        }

        private void steam_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe");
        }

        private void epicgameslauncher_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi");
        }

        private void valorant_Click(object sender, EventArgs e)
        {
            DownloadProgram("https://valorant.secure.dyn.riotcdn.net/channels/public/x/installer/current/live.live.eu.exe");
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
