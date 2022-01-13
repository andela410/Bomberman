using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bomberman.Classes
{
    public class Bomb
    {
        PictureBox bomb, fire;
        private Timer BombTimer, FireTimer;
        private int X, Y;
        GameField Field;
        Form Form;
        int BombStrength = 2;
        List<PictureBox> Explosion = new List<PictureBox>();
        List<Tuple<int, int>> Bricks = new List<Tuple<int, int>>();

        public Bomb(Form form, GameField field, int x, int y)
        {
            X = x;
            Y = y;
            Field = field;
            Form = form;

            // inicijaliziraj timer za bombu
            BombTimer = new Timer();
            BombTimer.Interval = 3000;
            BombTimer.Tick += new EventHandler(BombTimer_Tick);

            // inicijaliziraj timer za eksploziju
            FireTimer = new Timer();
            FireTimer.Interval = 1000;
            FireTimer.Tick += new EventHandler(FireTimer_Tick);

            bomb = new PictureBox();
            fire = new PictureBox();
        }
        public void PlantBomb()
        {
            bomb.Name = "Bomb" + X.ToString() + Y.ToString();
            bomb.SizeMode = PictureBoxSizeMode.AutoSize;
            bomb.Location = new Point(Y * Field.ElementSize + 10 + 2, X * Field.ElementSize + 40 + 2);
            bomb.Image = Properties.Resources.Bomb;
            Form.Controls.Add(bomb);
            bomb.BringToFront();

            SetExplosion(X, Y);
            for (int i = 1; i <= BombStrength; i++)
            {
                if (Field.Field[X + i, Y] == 'w')
                {
                    break;
                }
                SetExplosion(X + i, Y);
            }

            for (int i = 1; i <= BombStrength; i++)
            {
                if (Field.Field[X, Y + i] == 'w')
                {
                    break;
                }
                SetExplosion(X, Y + i);
            }

            for (int i = 1; i <= BombStrength; i++)
            {
                if (Field.Field[X - i, Y] == 'w')
                {
                    break;
                }
                SetExplosion(X - i, Y);
            }


            for (int i = 1; i <= BombStrength; i++)
            {
                if (Field.Field[X, Y - i] == 'w')
                {
                    break;
                }
                SetExplosion(X, Y - i);
            }

            BombTimer.Enabled = true;
        }


        private void SetExplosion(int x, int y)
        {
            if (x > 0 && y > 0 && x < Field.GameFieldHeight && y < Field.GameFieldWidth && Field.Field[x, y] != 'w')
            {
                PictureBox e = new PictureBox();
                e.Name = "Fire" + x.ToString() + y.ToString();
                e.SizeMode = PictureBoxSizeMode.AutoSize;
                e.Location = new Point(y * Field.ElementSize + 10, x * Field.ElementSize + 40);
                e.Image = Properties.Resources.Fire1;
                Form.Controls.Add(e);

                Explosion.Add(e);

                if (Field.Field[x, y] == 'b')
                {
                    Bricks.Add(new Tuple<int, int>(x, y));
                }
            }
        }
        private void BombTimer_Tick(object sender, EventArgs e)
        {
            bomb.Visible = false;
            BombTimer.Enabled = false;

            // eksplozija
            foreach (var ex in Explosion)
            {
                ex.BringToFront();
            }
            FireTimer.Enabled = true;
        }

        private void FireTimer_Tick(object sender, EventArgs e)
        {
            FireTimer.Enabled = false;

            // ugasi eksploziju
            foreach (var ex in Explosion)
            {
                ex.Visible = false;

            }

            // unisti cigle eksplozijom
            foreach (var coordinates in Bricks)
            {
                Brick brick = new Brick();
                brick.DestroyBrickWall(Form, coordinates.Item1, coordinates.Item2);
            }
        }
    }
}
