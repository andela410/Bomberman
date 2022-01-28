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
        Form levelMenu;
        Form settingsForm;
        PlayerKeys p1keys;
        PlayerKeys p2keys;

        public bool SviraMuzika
        {
            get { return sviraMuzika; }
            set { sviraMuzika = value; }
        }

        public Menu()
        {
            InitializeComponent();
            int vert_pomak = (Height - naslov.Height - 5 * campaignButton.Height) / 2;
            naslov.Location = new Point((Width - naslov.Width) / 2, vert_pomak);
            vert_pomak += 25;
            campaignButton.Location = new Point((Width - campaignButton.Width) / 3, vert_pomak + 120);
            singleplayerButton.Location = new Point((Width - campaignButton.Width) / 3, vert_pomak + 250);
            multiplayerButton.Location = new Point((Width - campaignButton.Width) / 3, vert_pomak + 380);

            settingsButton.Location = new Point((Width - settingsButton.Width) * 2 / 3, vert_pomak + 120);
            scoreboardButton.Location = new Point((Width - scoreboardButton.Width) * 2 /3, vert_pomak + 250);
            exitButton.Location = new Point((Width - exitButton.Width) * 2 /3, vert_pomak + 380);

            naslov.FlatAppearance.MouseOverBackColor = naslov.BackColor;
            naslov.BackColorChanged += (s, e) => {
                naslov.FlatAppearance.MouseOverBackColor = naslov.BackColor;
            };

            soundPlayer = new SoundPlayer(Properties.Resources.Black_Betty);
            //soundPlayer.PlayLooping();
            sviraMuzika = true;
            p1keys = new PlayerKeys("a", "w", "s", "d", "c");
            p2keys = new PlayerKeys("j", "i", "k", "l", "n");
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
            Hide();
            settingsForm = new Settings(this, p1keys, p2keys);

            settingsForm.Show();
            settingsForm.Closed += (s, args) => { Show(); };
        }

        private void campaignButton_Click(object sender, EventArgs e)
        {
            Hide();
            levelMenu = new LevelMenu(this, 1, p1keys, p2keys);
            levelMenu.Show();
            levelMenu.Closed += (s, args) => { Show(); };
        }

        private void singleplayerButton_Click(object sender, EventArgs e)
        {
            Hide();
            levelMenu = new LevelMenu(this, 2, p1keys, p2keys);
            levelMenu.Show();
            levelMenu.Closed += (s, args) => { Show(); };
        }

        private void multiplayerButton_Click(object sender, EventArgs e)
        {
            Hide();
            levelMenu = new LevelMenu(this, 3, p1keys, p2keys);
            levelMenu.Show();
            levelMenu.Closed += (s, args) => { Show(); };
        }
    }
}
