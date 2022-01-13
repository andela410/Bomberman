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

        protected const char EmptyElement = ' ';
        protected const char Wall = 'w';
        protected const char Brick = 'b';
        protected const char Enemy = 'e';
        protected const char Player = 'p';
        protected const char Bomb = 'o';
        protected const char Explosion = 'x';


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
        
        public char [,] Field
        {
            get { return field; }
        }

        protected char[,] field = new char[29, 13];
        public GameField() { }

        public void CreateGameField(Form formInstance)
        {
            PictureBox p = new PictureBox();
            p.Name = "GameField";
            p.SizeMode = PictureBoxSizeMode.AutoSize;
            p.Location = new Point(10, 40);
            p.Image = Properties.Resources.GameField;
            formInstance.Controls.Add(p);
            p.BringToFront();
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
                        { 'w', 'b', ' ', ' ', ' ', ' ', ' ', 'b', 'b', ' ', ' ', ' ', 'b', ' ', 'b', 'b', ' ', ' ', ' ', ' ', 'b', 'b', ' ', ' ', 'b', ' ', ' ', 'b', 'w' },
                        { 'w', 'b', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', 'b', ' ', 'b', ' ', 'b', ' ', ' ', ' ', 'b', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', 'b', ' ', 'b', 'b', ' ', ' ', 'b', ' ', 'w' },
                        { 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w' },
                        { 'w', ' ', ' ', 'b', 'b', ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'b', ' ', ' ', ' ', 'b', 'b', ' ', ' ', ' ', 'b', ' ', 'b', ' ', 'w' },
                        { 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', 'b', ' ', 'b', 'b', ' ', ' ', 'b', ' ', ' ', ' ', 'b', 'b', ' ', ' ', 'b', 'b', ' ', 'b', ' ', 'b', ' ', ' ', ' ', ' ', 'w' },
                        { 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w', 'b', 'w', ' ', 'w' },
                        { 'w', ' ', ' ', ' ', 'b', ' ', ' ', 'b', 'b', 'b', ' ', ' ', 'b', 'b', ' ', ' ', 'b', ' ', 'b', ' ', ' ', 'b', 'b', ' ', ' ', 'b', ' ', 'b', 'w' },            
                        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' }
                    };
                    break;
                default:
                    break;
            }
        }
    }
}
