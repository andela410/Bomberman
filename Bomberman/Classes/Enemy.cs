using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace Bomberman.Classes
{
    public class Enemy
    {
        private int xEnemy, yEnemy;
        GameField Field;
        Form Form;
        PictureBox enemyPicture;
        string Direction;

        public int XEnemy
        {
            get { return xEnemy; }
        }

        public int YEnemy
        {
            get { return yEnemy; }
        }

        public Enemy(Form form, GameField field, int x, int y, string direction)
        {
            xEnemy = x;
            yEnemy = y;
            Field = field;
            Form = form;
            Direction = direction;


            enemyPicture = new PictureBox();

            SetEnemy(x, y);
        }

        private void SetEnemy(int x, int y) //pozovi u konstruktoru
        {
            // enemy nekako nestane s mape
        }

            //PictureBox e = new PictureBox();
            // e.Name = "Fire" + x.ToString() + y.ToString();

        private void SetEnemy(int x, int y) //pozovi u konstruktoru
        {
            enemyPicture.Name = "Enemy" + xEnemy.ToString() + yEnemy.ToString();
            enemyPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyPicture.Location = new Point(x * Field.ElementSize + Field.PictureBox.Location.X, y * Field.ElementSize + Field.PictureBox.Location.Y);
            Bitmap Enemy_transparent = new Bitmap(Properties.Resources.Enemy);
            

            Enemy_transparent.MakeTransparent(Color.White);
            enemyPicture.Image = Enemy_transparent;
            Form.Controls.Add(enemyPicture);

            enemyPicture.BringToFront();
        }

        public void Move()
        {

            if (Direction == "left")
            {
                if (Field.Field[xEnemy, yEnemy - 1] != 'w' && Field.Field[xEnemy, yEnemy - 1] != 'b' && Field.Field[xEnemy, yEnemy - 1] != 'h')
                {
                    yEnemy--;
                }
                else if (Field.Field[xEnemy, yEnemy + 1] != 'w' && Field.Field[xEnemy, yEnemy + 1] != 'b' && Field.Field[xEnemy, yEnemy + 1] != 'h')
                {
                    yEnemy++;
                    Direction = "right";
                }
            }
            else if (Direction == "right")
            {
                if (Field.Field[xEnemy, yEnemy + 1] != 'w' && Field.Field[xEnemy, yEnemy + 1] != 'b' && Field.Field[xEnemy, yEnemy + 1] != 'h')
                {
                    yEnemy++;
                }
                else if (Field.Field[xEnemy, yEnemy - 1] != 'w' && Field.Field[xEnemy, yEnemy - 1] != 'b' && Field.Field[xEnemy, yEnemy - 1] != 'h')
                {
                    yEnemy--;
                    Direction = "left";
                    }
                }


                enemyPicture.Location = new Point(yEnemy * Field.ElementSize + Field.PictureBox.Location.X, xEnemy * Field.ElementSize + Field.PictureBox.Location.Y);
                Form.Controls.Add(enemyPicture);

                enemyPicture.BringToFront();
            }

    }
}
