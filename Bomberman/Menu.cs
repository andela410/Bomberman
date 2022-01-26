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
        private bool sviraMuzika;
        public bool SviraMuzika
        {
            get { return sviraMuzika; }
            set { sviraMuzika = value; }
        }

        public Menu()
        {
            InitializeComponent();
            int vert_pomak = (this.Height - this.naslov.Height - 5 * this.campaignButton.Height) / 2;
            this.naslov.Location = new Point((this.Width - this.naslov.Width) / 2, vert_pomak);
            vert_pomak += 25;
            this.campaignButton.Location = new Point((this.Width - this.campaignButton.Width) / 3, vert_pomak + 120);
            this.singleplayerButton.Location = new Point((this.Width - this.campaignButton.Width) / 3, vert_pomak + 250);
            this.multiplayerButton.Location = new Point((this.Width - this.campaignButton.Width) / 3, vert_pomak + 380);

            this.settingsButton.Location = new Point((this.Width - this.settingsButton.Width) * 2 / 3, vert_pomak + 120);
            this.scoreboardButton.Location = new Point((this.Width - this.scoreboardButton.Width) * 2 /3, vert_pomak + 250);
            this.exitButton.Location = new Point((this.Width - this.exitButton.Width) * 2 /3, vert_pomak + 380);

            naslov.FlatAppearance.MouseOverBackColor = naslov.BackColor;
            naslov.BackColorChanged += (s, e) => {
                naslov.FlatAppearance.MouseOverBackColor = naslov.BackColor;
            };

            soundPlayer = new SoundPlayer(Properties.Resources.Black_Betty);
            soundPlayer.PlayLooping();
            sviraMuzika = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form settingsForm = new Settings(this);
            settingsForm.Show();
            settingsForm.Closed += (s, args) => { this.Show(); };
        }

        private void campaignButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form levelMenu = new LevelMenu(this, 1);
            levelMenu.Show();
            levelMenu.Closed += (s, args) => { this.Show(); };
        }

        private void singleplayerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form levelMenu = new LevelMenu(this, 2);
            levelMenu.Show();
            levelMenu.Closed += (s, args) => { this.Show(); };
        }

        private void multiplayerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form levelMenu = new LevelMenu(this, 3);
            levelMenu.Show();
            levelMenu.Closed += (s, args) => { this.Show(); };
        }
    }
}
