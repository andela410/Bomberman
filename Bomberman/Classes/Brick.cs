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
                        brick.Location = new Point(j * Field.ElementSize + 10, i * Field.ElementSize + 40);
                        brick.Image = Properties.Resources.Brick;
                        formInstance.Controls.Add(brick);
                        brick.BringToFront();
                    }
                }
            }
        }

        public void DestroyBrickWall(Form formInstance, int x, int y)
        {
            Control[] bricks = formInstance.Controls.Find("Brick" + x.ToString() + y.ToString(), false);

            if (bricks != null && bricks.Length > 0)
            {
                bricks[0].Visible = false;
            }

        }
    }
}
