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
    public partial class Menu : Form
    {
        SoundPlayer soundPlayer;
        bool isPlaying;

        public Menu()
        {
            InitializeComponent();
            int vert_pomak = (this.Height - this.naslov.Height - 5 * this.newGameButton.Height) / 2;
            this.naslov.Location = new Point((this.Width - this.naslov.Width) / 2, vert_pomak);
            vert_pomak += 25;
            this.newGameButton.Location = new Point((this.Width - this.newGameButton.Width) / 2, vert_pomak + 115);
            this.settingsButton.Location = new Point((this.Width - this.settingsButton.Width) / 2, vert_pomak + 230);
            this.scoreboardButton.Location = new Point((this.Width - this.scoreboardButton.Width) / 2, vert_pomak + 345);
            this.exitButton.Location = new Point((this.Width - this.exitButton.Width) / 2, vert_pomak + 460);

            naslov.FlatAppearance.MouseOverBackColor = naslov.BackColor;
            naslov.BackColorChanged += (s, e) => {
                naslov.FlatAppearance.MouseOverBackColor = naslov.BackColor;
            };

            soundPlayer = new SoundPlayer(Properties.Resources.Black_Betty);
            soundPlayer.PlayLooping();
            isPlaying = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form levelMenu = new LevelMenu(this);
            levelMenu.Show();
            levelMenu.Closed += (s, args) => { this.Show(); };
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool sviraMuzika = true;
        public bool SviraMuzika
        {
            get { return sviraMuzika; }
            set { sviraMuzika = value; }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form settingsForm = new Settings(this);
            settingsForm.Show();
            settingsForm.Closed += (s, args) => { this.Show(); };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                soundPlayer.Stop();
                pictureBox1.BackgroundImage = Properties.Resources.soundOn;
                isPlaying = false;
                Refresh();
            }
            else
            {
                soundPlayer.Play();
                pictureBox1.BackgroundImage = Properties.Resources.soundOff;
                isPlaying = true;
                Refresh();
            }
        }
    }
}
