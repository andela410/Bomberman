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
        Form Form;
        GameField Field;

        public Brick(Form form, GameField field)
        {
            Form = form;
            Field = field;
        }

        public void CreateBrickWalls()
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
                        Form.Controls.Add(brick);
                        brick.BringToFront();
                    }
                }
            }
        }

        public bool DestroyBrickWall(int x, int y)
        {
            Control[] bricks = Form.Controls.Find("Brick" + x.ToString() + y.ToString(), false);

            if (bricks != null && bricks.Length > 0)
            {
                ShowScore(100, x, y);
                Field.UpdateField(x, y);
                bricks[0].Visible = false;
                return true;
            }
            return false;
        }

        System.Timers.Timer ScoreTimer;
        
        async private void ShowScore(int score, int x, int y)
        {
            Label ScoreText = new Label();

            ScoreText.ForeColor = Color.White;
            ScoreText.BackColor = Color.DarkOliveGreen;
            ScoreText.Font = new System.Drawing.Font("Folio XBd BT", 7);
            ScoreText.Top = Field.ElementSize * x + 5 + Field.PictureBox.Location.Y;
            ScoreText.Left = Field.ElementSize * y + 5 + Field.PictureBox.Location.X;
            ScoreText.Height = 15;
            ScoreText.Width = 25;
            ScoreText.Text = score.ToString();
            Form.Controls.Add(ScoreText);
            ScoreText.BringToFront();

            await Task.Delay(300);

            ScoreText.Visible = false;
        }

        void ScoreVanish_tick(object sender, EventArgs e, Label label)
        {
            label.Visible = false;
            ScoreTimer.Enabled = false;
        }
    }
}
