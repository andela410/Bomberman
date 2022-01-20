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
        public LevelMenu()
        {
            InitializeComponent();

            int vert_pomak = Height/8;
            int hor_pomak = Width - button1.Width *3/2;
            button1.Location = new Point(hor_pomak, vert_pomak);
            button2.Location = new Point(hor_pomak, vert_pomak + button2.Height * 11 / 10);
            button3.Location = new Point(hor_pomak, vert_pomak + button3.Height * 22 / 10);
            button4.Location = new Point(hor_pomak, vert_pomak + button4.Height * 33 / 10);
            button5.Location = new Point(hor_pomak, vert_pomak + button5.Height * 44 / 10);

            choosePlayer.Width = playersPanel.Width;

            vert_pomak = Height/8 + (button1.Height * 54/10 -playersPanel.Height)/2;
            hor_pomak = playersPanel.Width * 1 / 2;//zasto ovdje nije dovoljno bez faktora 2?(mozda neka losa pretvorba jedinica)
            playersPanel.Location = new Point(hor_pomak, vert_pomak);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = ((Button)sender).Name;
            int level = ime.Last() - '0';
            if (this.radioButton1.Checked || this.radioButton2.Checked || this.radioButton3.Checked || this.radioButton4.Checked)
            {
                this.Hide();
                Form Form1 = new Form1(level, 1);

                if (this.radioButton1.Checked)
                    Form1 = new Form1(level, 1);
                else if (this.radioButton2.Checked)
                    Form1 = new Form1(level, 2);
                else if (this.radioButton3.Checked)
                    Form1 = new Form1(level, 3);
                else
                    Form1 = new Form1(level, 4);
                
                Form1.Show();
                Form1.Closed += (s, args) => { this.Show(); };
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
