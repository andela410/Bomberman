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

            int vert_pomak = (this.Height - 7 * this.button1.Height) / 2;
            int hor_pomak = (this.Width - 3 * this.button1.Width) / 2 - 5;
            this.button1.Location = new Point(hor_pomak, vert_pomak);
            this.button2.Location = new Point(hor_pomak, vert_pomak + 105);
            this.button3.Location = new Point(hor_pomak, vert_pomak + 210);
            this.button4.Location = new Point(hor_pomak, vert_pomak + 315);
            this.button5.Location = new Point(hor_pomak, vert_pomak + 420);

            hor_pomak += 2 * this.button1.Width + 200;//zasto ovdje nije dovoljno bez faktora 2?(mozda neka losa pretvorba jedinica)
            this.panel1.Location = new Point(hor_pomak, vert_pomak + 2 * this.button1.Height);
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
