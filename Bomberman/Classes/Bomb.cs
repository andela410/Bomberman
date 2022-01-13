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
        public void PlantBomb(Form formInstance, GameField Field, int x, int y)
        {
            PictureBox bomb = new PictureBox();

            bomb.Name = "Bomb" + x.ToString() + y.ToString();
            bomb.SizeMode = PictureBoxSizeMode.AutoSize;
            bomb.Location = new Point(y * Field.ElementSize + 10 + 2, x * Field.ElementSize + 40 + 2);
            bomb.Image = Properties.Resources.Bomb;
            formInstance.Controls.Add(bomb);
            bomb.BringToFront();
        }
    }
}
