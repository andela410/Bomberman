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
        public Settings()
        {
            InitializeComponent();
            player = new SoundPlayer(Properties.Resources.Black_Betty);
        }

        private void SoundOnOff_Click(object sender, EventArgs e)
        {
            if(SoundOnOff.Tag == "on")
            {
                player.Stop();
                SoundOnOff.Tag = "off";
                SoundOnOff.BackgroundImage = Properties.Resources.soundOn;
            }
            else if (SoundOnOff.Tag == "off")
            {
                player.PlayLooping();
                SoundOnOff.Tag = "on";
                SoundOnOff.BackgroundImage = Properties.Resources.soundOff;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (SoundOnOff.Tag == "off")
            {
                SoundOnOff.BackgroundImage = Properties.Resources.soundOn;
            }
            else if (SoundOnOff.Tag == "on")
            {
                SoundOnOff.BackgroundImage = Properties.Resources.soundOff;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new Menu();
            menu.Show();
        }
    }
}
