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
            this.naslov.Location = new Point((this.Width - this.naslov.Width) / 2,  0);
            this.newGameButton.Location = new Point((this.Width - this.newGameButton.Width) / 2, 100);
            this.controlsButton.Location = new Point((this.Width - this.controlsButton.Width) / 2, 200);
            this.scoreboardButton.Location = new Point((this.Width - this.scoreboardButton.Width) / 2, 300);
            this.exitButton.Location = new Point((this.Width - this.exitButton.Width) / 2, 400);

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
            f1.Closed += (s, args) => { this.Show(); };
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
