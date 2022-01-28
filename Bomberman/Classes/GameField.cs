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
        protected const char HiddenDoor = 'h';
        protected const char Door = 'd';
        protected const char Explosion = 'x';

        protected const int NumberOfLevels = 5;
        protected const int MaxHeight = 13;
        protected const int MaxWidth = 29;
        protected PictureBox pictureBox;
    
        protected char[,] field = new char[MaxHeight, MaxWidth];

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

        //public List<char[,]> Fields
        //{
        //    get { return fields; }
        //}

        public GameField(Form form)
        {
            Form = form;
        }

        public void CreateGameField(int level, int player_number)
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
            switch(Level)
            {
                case 1:
                    field = new char[,]
                    {
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' },
                        { 'w', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'b', 'b', 'b', ' ', ' ', 'w' },
                        { 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w' },
                        { 'w', 'b', 'b', 'b', ' ', ' ', ' ', ' ', 'b', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'b', ' ', ' ', ' ', 'b', ' ', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', 'b', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', 'b', ' ', 'w' },
                        { 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', 'b', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'w' },
                        { 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', 'b', ' ', 'b', 'b', 'h', ' ', ' ', ' ', ' ', ' ', 'b', ' ', 'b', ' ', 'b', ' ', ' ', ' ', ' ', 'b', ' ', 'b', ' ', ' ', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', ' ', 'b', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', 'b', 'b', 'b', 'b', 'b', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', 'w' },
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' }
                    };
                    break;
                case 2:
                    field = new char[,]
                    {
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' },
                        { 'w', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', 'b', ' ', 'b', ' ', ' ', ' ', ' ', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', 'b', 'w', 'b', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', 'b', ' ', ' ', 'h', 'b', ' ', 'b', 'w' },
                        { 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', ' ', 'b', 'b', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', 'b', ' ', ' ', 'b', 'b', ' ', 'b', ' ', 'b', ' ', ' ', ' ', ' ', ' ', 'b', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', 'b', ' ', ' ', ' ', 'b', 'b', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', 'b', ' ', ' ', 'b', ' ', ' ', ' ', ' ', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'b', ' ', 'b', ' ', 'w' },
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' }
                    };
                    break;
                case 3:
                    field = new char[,]
                    {
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' },
                        { 'w', ' ', ' ', 'b', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'b', ' ', 'b', 'b', ' ', 'b', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', ' ', 'b', ' ', ' ', 'b', 'b', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'h', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'w' },
                        { 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'b', 'b', ' ', 'b', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'b', ' ', 'b', 'b', 'b', 'b', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'w' },
                        { 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', ' ', 'b', 'b', ' ', ' ', ' ', ' ', 'b', 'b', 'b', ' ', ' ', 'b', 'b', 'b', ' ', ' ', 'b', 'b', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'w' },
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' }
                    };
                    break;
                case 4:
                    field = new char[,]
                    {
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' },
                        { 'w', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', 'b', ' ', 'b', ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'b', ' ', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', ' ', 'b', ' ', 'b', ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', 'b', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'b', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', 'b', ' ', ' ', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', 'b', ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ', 'b', 'b', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', 'b', ' ', ' ', ' ', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'b', 'b', 'b', ' ', ' ', ' ', ' ', 'b', ' ', ' ', 'b', ' ', 'h', ' ', ' ', 'w' },
                        { 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', 'b', ' ', ' ', 'b', ' ', 'b', ' ', ' ', 'b', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'w' },
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' }
                    };
                    break;
                case 5:
                    field = new char[,]
                    {
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' },
                        { 'w', ' ', ' ', 'b', ' ', 'b', ' ', ' ', 'b', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', 'b', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', 'b', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'b', 'b', ' ', ' ', ' ', 'b', ' ', ' ', 'b', ' ', ' ', ' ', ' ', 'w' },
                        { 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w' },
                        { 'w', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'b', 'w' },
                        { 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'h', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', ' ', 'b', ' ', 'b', 'b', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', 'b', ' ', ' ', 'b', 'b', ' ', ' ', ' ', 'w' },
                        { 'w', ' ', 'w', 'b', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', ' ', ' ', 'b', 'b', 'b', ' ', ' ', ' ', ' ', ' ', 'b', 'b', ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'w' },
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', 'b', 'w', 'b', 'w', 'b', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'b', 'b', ' ', 'b', 'b', 'b', ' ', ' ', 'b', 'b', ' ', ' ', ' ', ' ', ' ', ' ', 'b', ' ', 'w' },
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' }
                    };
                    break;
                default:
                    break;
            }
        }

        internal void ShowDoors()
        {
            field[11, 1] = 'd'; // Ako uopce treba ova funkcija, ovo treba biti dinamicki, kao i dolje u kodu

            PictureBox p = new PictureBox();
            p.Name = "Doors";
            p.SizeMode = PictureBoxSizeMode.AutoSize;
            p.Location = new Point(11 * ElementSize + PictureBox.Location.X, 1 * ElementSize + PictureBox.Location.Y);
            Bitmap Door_transparent = new Bitmap(Properties.Resources.Door);

            Door_transparent.MakeTransparent(Color.White);
            p.Image = Door_transparent;
            Form.Controls.Add(p);

            p.BringToFront();
        }

        public void UpdateField(int x, int y)
        {
            field[x, y] = ' ';
        }
    }
}