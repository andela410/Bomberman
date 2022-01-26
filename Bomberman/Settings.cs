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
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
            backButton.Location = new Point(Width - backButton.Width * 11 / 8, 12);
            soundLabel.Location = new Point(Width / 2 - soundLabel.Width / 2 - SoundOnOff.Width / 2, 50);
            SoundOnOff.Location = new Point(Width / 2 + soundLabel.Width / 2, 50);
            controlsLabel.Location = new Point(Width / 2 - controlsLabel.Width / 2, Height / 3 - controlsLabel.Height * 2);
            igrac1Kontrola.Location = new Point(Width/2 - igrac1Kontrola.Width - (Width / 2 - igrac1Kontrola.Width) / 4, Height /3);
            igrac2Kontrola.Location = new Point(Width/2 +(Width / 2 - igrac2Kontrola.Width) / 4, Height / 3);
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

        private void promjenaKontrole(object sender, EventArgs e)
        {

        }
    }
}
