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
        PlayerKeys P1keys;
        PlayerKeys P2keys;

        public Settings(Menu tempMenu, PlayerKeys p1keys, PlayerKeys p2keys)
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
            P1keys = p1keys;
            P2keys = p2keys;
            if (menu.SviraMuzika)
            {
                SoundOnOff.Tag = "on";
                SoundOnOff.BackgroundImage = Properties.Resources.soundOff;
            }
            else
            {
                SoundOnOff.Tag = "off";
                SoundOnOff.BackgroundImage = Properties.Resources.soundOn;
            }

            L1.Text = P1keys.Left;
            U1.Text = P1keys.Up;
            R1.Text = P1keys.Right;
            D1.Text = P1keys.Down;
            B1.Text = P1keys.Bomb;
            L2.Text = P2keys.Left;
            U2.Text = P2keys.Up;
            R2.Text = P2keys.Right;
            D2.Text = P2keys.Down;
            B2.Text = P2keys.Bomb;
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
            TextBox box = (TextBox)sender;

            switch (box.Name)
            {
                case "L1":
                    P1keys.Left = box.Text;
                    break;
                case "U1":
                    P1keys.Up = box.Text;
                    break;
                case "R1":
                    P1keys.Right = box.Text;
                    break;
                case "D1":
                    P1keys.Down = box.Text;
                    break;
                case "B1":
                    P1keys.Bomb = box.Text;
                    break;
                case "L2":
                    P2keys.Left = box.Text;
                    break;
                case "U2":
                    P2keys.Up = box.Text;
                    break;
                case "R2":
                    P2keys.Right = box.Text;
                    break;
                case "D2":
                    P2keys.Down = box.Text;
                    break;
                case "B2":
                    P2keys.Bomb = box.Text;
                    break;
            }
        }
    }
}
