using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            int vert_pomak = (this.Height - this.naslov.Height - 5 * this.newGameButton.Height) / 2;
            this.naslov.Location = new Point((this.Width - this.naslov.Width) / 2, vert_pomak);
            vert_pomak += 25;
            this.newGameButton.Location = new Point((this.Width - this.newGameButton.Width) / 2, vert_pomak + 115);
            this.controlsButton.Location = new Point((this.Width - this.controlsButton.Width) / 2, vert_pomak + 230);
            this.scoreboardButton.Location = new Point((this.Width - this.scoreboardButton.Width) / 2, vert_pomak + 345);
            this.exitButton.Location = new Point((this.Width - this.exitButton.Width) / 2, vert_pomak + 460);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form levelMenu = new LevelMenu();
            levelMenu.Show();
            levelMenu.Closed += (s, args) => { this.Show(); };
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
