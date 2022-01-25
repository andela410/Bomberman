using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Bomberman
{
    public partial class Settings : Form
    {
        SoundPlayer player;
        Menu menu;
        public Settings(Menu tempMenu)
        {
            InitializeComponent();
            backButton.Location = new Point(Width - backButton.Width * 11 / 8, 12);
            player = new SoundPlayer(Properties.Resources.Black_Betty);
            menu = tempMenu;
            if(menu.SviraMuzika)
            {
                SoundOnOff.Tag = "on";
                SoundOnOff.BackgroundImage = Properties.Resources.soundOff;
            } else
            {
                SoundOnOff.Tag = "off";
                SoundOnOff.BackgroundImage = Properties.Resources.soundOn;
            }
        }

        private void SoundOnOff_Click(object sender, EventArgs e)
        {
            if(menu.SviraMuzika)
            {
                player.Stop();
                SoundOnOff.Tag = "off";
                menu.SviraMuzika = false;
                SoundOnOff.BackgroundImage = Properties.Resources.soundOn;
            }
            else
            {
                player.PlayLooping();
                SoundOnOff.Tag = "on";
                menu.SviraMuzika = true;
                SoundOnOff.BackgroundImage = Properties.Resources.soundOff;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
