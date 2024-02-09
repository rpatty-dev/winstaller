using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winstaller
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            CenterToScreen();
            social.Click += social_Click;
            toolsbtn.Click += toolsbtn_Click;
            pc.Click += pc_Click;
            qol.Click += qol_Click;
            driver.Click += driver_Click;
            game.Click += game_Click;
            backbtn.Click += backbtn_Click;
            browsers.Click += browsers_Click;
        }

        private void social_Click(object sender, EventArgs e)
        {
            social social = new social();
            social.Show();
            this.Hide();
        }

        private void toolsbtn_Click(object sender, EventArgs e)
        {
            tools tools = new tools();
            tools.Show();
            this.Hide();
        }

        private void pc_Click(object sender, EventArgs e)
        {
            pc pc = new pc();
            pc.Show();
            this.Hide();
        }

        private void qol_Click(object sender, EventArgs e)
        {
            qol qol = new qol();
            qol.Show();
            this.Hide();
        }

        private void driver_Click(object sender, EventArgs e)
        {
            driver driver = new driver();
            driver.Show();
            this.Hide();
        }

        private void game_Click(object sender, EventArgs e)
        {
            game game = new game();
            game.Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Welcome Welcome = new Welcome();
            Welcome.Show();
            this.Hide();
        }

        private void browsers_Click(object sender, EventArgs e)
        {
            browsers browsers = new browsers();
            browsers.Show();
            this.Hide();
        }
    }
}
