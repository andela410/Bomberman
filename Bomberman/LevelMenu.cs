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
    public partial class LevelMenu : Form
    {
        Menu menu;
        public LevelMenu(Menu tempMenu, int menuType)
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
            menu = tempMenu;
            int vert_pomak, hor_pomak;
            if(menuType == 1) //Campaign
            {
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button4.Hide();
                button5.Hide();
                player2panel.Hide();
                player1panel.Width = choosePlayer1.Width;
                vert_pomak = (Height - player1panel.Height) / 2;
                hor_pomak = (Width - player1panel.Width) / 2;
                player1panel.Location = new Point(hor_pomak, vert_pomak);
            }
            else if (menuType == 3) //Multiplayer
            {
                vert_pomak = Height / 2 - button1.Height *54/20;
                hor_pomak = Width/2 + (Width/2 - button1.Width/2)/3 ;
                button1.Location = new Point(hor_pomak, vert_pomak);
                button2.Location = new Point(hor_pomak, vert_pomak + button2.Height * 11 / 10);
                button3.Location = new Point(hor_pomak, vert_pomak + button3.Height * 22 / 10);
                button4.Location = new Point(hor_pomak, vert_pomak + button4.Height * 33 / 10);
                button5.Location = new Point(hor_pomak, vert_pomak + button5.Height * 44 / 10);

                player1panel.Width = choosePlayer1.Width;
                player2panel.Width = choosePlayer2.Width;
                vert_pomak = Height / 2 - player1panel.Height/2;

                hor_pomak = (Width / 2 - player1panel.Width - player2panel.Width) /3;
                player1panel.Location = new Point(hor_pomak, vert_pomak);
                
                hor_pomak = hor_pomak*2 + player1panel.Width;
                player2panel.Location = new Point(hor_pomak, vert_pomak);
            } else //Singleplayer
            {
                player2panel.Hide();
                vert_pomak = Height / 2 - button1.Height * 54 / 20;
                hor_pomak = Width / 2 + (Width / 2 - button1.Width / 2) / 3;
                button1.Location = new Point(hor_pomak, vert_pomak);
                button2.Location = new Point(hor_pomak, vert_pomak + button2.Height * 11 / 10);
                button3.Location = new Point(hor_pomak, vert_pomak + button3.Height * 22 / 10);
                button4.Location = new Point(hor_pomak, vert_pomak + button4.Height * 33 / 10);
                button5.Location = new Point(hor_pomak, vert_pomak + button5.Height * 44 / 10);
                player1panel.Width = choosePlayer1.Width;
                vert_pomak = Height / 2 - player1panel.Height / 2;
                hor_pomak =(Width / 2 - player1panel.Width / 2) / 3;
                player1panel.Location = new Point(hor_pomak, vert_pomak);
            }
            backButton.Location = new Point(Width - backButton.Width *11/8, 12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = ((Button)sender).Name;
            int level = ime.Last() - '0';
            if (this.radioButton1.Checked || this.radioButton2.Checked || this.radioButton3.Checked || this.radioButton4.Checked)
            {
                this.Hide();
                Form Form1;

                if (this.radioButton1.Checked)
                    Form1 = new Form1(level, 1);
                else if (this.radioButton2.Checked)
                    Form1 = new Form1(level, 2);
                else if (this.radioButton3.Checked)
                    Form1 = new Form1(level, 3);
                else
                    Form1 = new Form1(level, 4);
                
                Form1.Show();
                Form1.Closed += (s, args) => { this.Show(); Form1.Dispose(); };
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
    }
}
