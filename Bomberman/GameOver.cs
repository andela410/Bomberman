using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
            save.Location = new Point(Width/2 - save.Width/2, Height *2/3);
            gameOverLabel.Location = new Point(Width / 2 - gameOverLabel.Width / 2, Height / 4);
            nameTextBox.Location = new Point(Width / 2 - gameOverLabel.Width / 2, Height / 2);
            scoreLabel.Location = new Point(Width / 2 - gameOverLabel.Width / 2 + nameTextBox.Width + Width / 30, Height / 2);
            scoreNumber.Location = new Point(Width / 2 - gameOverLabel.Width / 2 + nameTextBox.Width + Width / 30 + scoreLabel.Width, Height / 2);
            //scoreNumber.Text = ToString(NEKI SCORE);
        }
        private void save_Click(object sender, EventArgs e)
        {
            string ime1 = nameTextBox.Text;
            //spremi ime i score u tablicu;
            Close();
        }
    }
}
