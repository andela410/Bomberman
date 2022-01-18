using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace Bomberman.Classes
{
    public class GameField
    {
        Form Form;

        protected const char EmptyElement = ' ';
        protected const char Wall = 'w';
        protected const char Brick = 'b';
        protected const char Enemy = 'e';
        protected const char Player = 'p';
        protected const char Bomb = 'o';
        protected const char Explosion = 'x';
        protected PictureBox pictureBox;

        public int GameFieldWidth
        {
            get { return 29; }
        }

        public int GameFieldHeight
        {
            get { return 13; }
        }

        public int ElementSize
        {
            get { return 40; }
        }

        public PictureBox PictureBox
        {
            get { return pictureBox; }
        }

        public char [,] Field
        {
            get { return field; }
        }

        protected char[,] field = new char[29, 13];

        public GameField(Form form)
        {
            Form = form;
        }

        public void CreateGameField()
        {
            PictureBox p = new PictureBox();
            p.Name = "GameField";
            p.SizeMode = PictureBoxSizeMode.AutoSize;
            p.Location = new Point((Form.Width - 29 * ElementSize) / 2, (Form.Height - 13 * ElementSize) / 2);
            p.Image = Properties.Resources.GameField;
            Form.Controls.Add(p);
            p.BringToFront();
            pictureBox = p;
        }

        public void InitializeGameField(int Level)
        {
            switch (Level)
            {
                case 1:
                    field = new char[,] {
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' },
                        { 'w', ' ', ' ', 'b', 'b', ' ', ' ', 'b', ' ', ' ', 'b', 'b', 'b', ' ', ' ', ' ', ' ', 'b', ' ', 'b', 'b', ' ', ' ', 'b', ' ', 'b', ' ', 'b', 'w' },
                        { 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'b', ' ', ' ', ' ', 'b', ' ', 'b', 'b', ' ', ' ', ' ', ' ', 'b', 'b', ' ', ' ', 'b', ' ', ' ', 'b', 'w' },
                        { 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', 'b', ' ', 'b', ' ', 'b', ' ', ' ', ' ', 'b', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', 'b', ' ', 'b', 'b', ' ', ' ', 'b', ' ', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w' },
                        { 'w', ' ', ' ', 'b', 'b', ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'b', 'b', ' ', ' ', ' ', 'b', ' ', 'b', ' ', 'w' },
                        { 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', 'b', ' ', 'b', 'b', ' ', ' ', 'b', ' ', ' ', ' ', 'b', 'b', ' ', ' ', 'b', 'b', ' ', 'b', ' ', 'b', ' ', ' ', ' ', ' ', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', 'b', ' ', ' ', 'b', 'b', 'b', ' ', ' ', 'b', 'b', ' ', ' ', 'b', ' ', 'b', ' ', ' ', 'b', 'b', ' ', ' ', 'b', ' ', 'b', 'w' },            
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' }
                    };
                    break;
                default:
                    break;
            }
        }

        public void UpdateField(int x, int y)
        {
            field[x, y] = ' ';
        }
    }
}
