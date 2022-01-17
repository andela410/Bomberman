using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bomberman.Classes
{
    public class Brick
    {
        Player Player;

        public Brick(Player player)
        {
            Player = player;
        }
        public void CreateBrickWalls(Form formInstance, GameField Field)
        {
            for (int i = 0; i < Field.GameFieldHeight; i++)
            {
                for (int j = 0; j < Field.GameFieldWidth; j++)
                {
                    if (Field.Field[i, j] == 'b')
                    {
                        PictureBox brick = new PictureBox();
                        brick.Name = "Brick" + i.ToString() + j.ToString();
                        brick.SizeMode = PictureBoxSizeMode.AutoSize;
                        brick.Parent = Field.PictureBox;
                        brick.Location = new Point(Field.PictureBox.Location.X + j * Field.ElementSize, Field.PictureBox.Location.Y + i * Field.ElementSize);
                        brick.Image = Properties.Resources.Brick;
                        formInstance.Controls.Add(brick);
                        brick.BringToFront();
                    }
                }
            }
        }

        public void DestroyBrickWall(Form formInstance, GameField Field, int x, int y)
        {
            Control[] bricks = formInstance.Controls.Find("Brick" + x.ToString() + y.ToString(), false);

            if (bricks != null && bricks.Length > 0)
            {
                Player.UpdateScore(100);
                ShowScore(formInstance, Field, 100, x, y);
                Field.UpdateField(x, y);
                bricks[0].Visible = false;
            }

        }

        System.Timers.Timer ScoreTimer;
        
        private void ShowScore(Form form, GameField field, int score, int x, int y)
        {
            Label ScoreText = new Label();

            ScoreText.ForeColor = Color.White;
            ScoreText.BackColor = Color.DarkOliveGreen;
            ScoreText.Font = new System.Drawing.Font("Folio XBd BT", 7);
            ScoreText.Top = field.ElementSize * x + 5 + field.PictureBox.Location.Y;
            ScoreText.Left = field.ElementSize * y + 5 + field.PictureBox.Location.X;
            ScoreText.Height = 15;
            ScoreText.Width = 25;
            ScoreText.Text = score.ToString();
            form.Controls.Add(ScoreText);
            ScoreText.BringToFront();

            ScoreTimer = new System.Timers.Timer();

            ScoreTimer.Elapsed += new System.Timers.ElapsedEventHandler((sender, e) => ScoreVanish_tick(sender, e, ScoreText));

            ScoreTimer.Interval = 300;
            ScoreTimer.Enabled = true;



        }

        void ScoreVanish_tick(object sender, EventArgs e, Label label)
        {
            //label.Visible = false;
            ScoreTimer.Enabled = false;

        }
    }
}
