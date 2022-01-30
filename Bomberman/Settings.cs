using System;
using System.Drawing;
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
            menu = tempMenu;

            //postavljamo button za glazbu ovisno o tome svira li ili ne
            player = new SoundPlayer(Properties.Resources.Black_Betty);                          
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

            //Popunjavaju se textboxovi s kontrolama
            P1keys = p1keys;
            P2keys = p2keys;
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
            bool newCommand;
            newCommand = true; //provjerava je li tipka nova ili je već pridružena nekoj kontroli ili je prazna
            if(P1keys.Left == box.Text || P1keys.Right == box.Text || P1keys.Up == box.Text || P1keys.Down == box.Text || P1keys.Bomb == box.Text)
            {
                newCommand = false;
            }
            if (P2keys.Left == box.Text || P2keys.Right == box.Text || P2keys.Up == box.Text || P2keys.Down == box.Text || P2keys.Bomb == box.Text)
            {
                newCommand = false;
            }
            if(box.Text == "")
            {
                newCommand = false;
            }
            //pridruživanje nove kontrole ako je nova tipka dobra, inače vraćamo textbox na staru vrijednost
            switch (box.Name)
            {
                case "L1":
                    if (newCommand)
                    {
                        P1keys.Left = box.Text;
                    } else
                    {
                        box.Text = P1keys.Left;
                    }
                    break;
                case "U1":
                    if (newCommand)
                    {
                        P1keys.Up = box.Text;
                    }
                    else
                    {
                        box.Text = P1keys.Up;
                    }
                    break;
                case "R1":
                    if (newCommand)
                    {
                        P1keys.Right = box.Text;
                    }
                    else
                    {
                        box.Text = P1keys.Right;
                    }
                    break;
                case "D1":
                    if (newCommand)
                    {
                        P1keys.Down = box.Text;
                    }
                    else
                    {
                        box.Text = P1keys.Down;
                    }
                    break;
                case "B1":
                    if (newCommand)
                    {
                        P1keys.Bomb = box.Text;
                    }
                    else
                    {
                        box.Text = P1keys.Bomb;
                    }
                    break;
                case "L2":
                    if (newCommand)
                    {
                        P2keys.Left = box.Text;
                    }
                    else
                    {
                        box.Text = P2keys.Left;
                    }
                    break;
                case "U2":
                    if (newCommand)
                    {
                        P2keys.Up = box.Text;
                    }
                    else
                    {
                        box.Text = P2keys.Up;
                    }
                    break;
                case "R2":
                    if (newCommand)
                    {
                        P2keys.Right = box.Text;
                    }
                    else
                    {
                        box.Text = P2keys.Right;
                    }
                    break;
                case "D2":
                    if (newCommand)
                    {
                        P2keys.Down = box.Text;
                    }
                    else
                    {
                        box.Text = P2keys.Down;
                    }
                    break;
                case "B2":
                    if (newCommand)
                    {
                        P2keys.Bomb = box.Text;
                    }
                    else
                    {
                        box.Text = P2keys.Bomb;
                    }
                    break;
            }
        }
    }
}
