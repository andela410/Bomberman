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
        LevelForm Form;

        Boolean LevelPass = false;

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

        public GameField(LevelForm form)
        {
            Form = form;
        }

        public void CreateGameField(int level)
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
                        { 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', 'b', 'w', 'b', 'w', ' ', 'w', ' ', 'w', 'b', 'w', ' ', 'w' },
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

        async public void ShowScore(int score, int x, int y)
        {
            Label ScoreText = new Label();

            ScoreText.ForeColor = Color.White;
            ScoreText.BackColor = Color.DarkOliveGreen;
            ScoreText.Font = new System.Drawing.Font("Folio XBd BT", 7);
            ScoreText.Top = ElementSize * x + 5 + PictureBox.Location.Y;
            ScoreText.Left = ElementSize * y + 5 + PictureBox.Location.X;
            ScoreText.Height = 15;
            ScoreText.Width = 25;
            ScoreText.Text = score.ToString();
            Form.Controls.Add(ScoreText);
            ScoreText.BringToFront();

            await Task.Delay(300);

            ScoreText.Visible = false;
        }
        public void UpdateField(int x, int y)
        {
            field[x, y] = ' ';
        }

        int DoorX;
        int DoorY;

        public void UpdateFieldToDoor(int x, int y)
        {
            field[x, y] = 'd';
            DoorX = x;
            DoorY = y;
        }

        public void UpdateFieldToBomb(int x, int y)
        {
            field[x, y] = 'b';
        }

        public void UpdateFieldToExplosion(int x, int y)
        {
            if (field[x, y] == ' ')
            {
                field[x, y] = 'x';
            }
        }
        public void EnableLevelPass()
        {
            LevelPass = true;
        }

        public void CheckIfLevelPassed(Player player)
        {
            if (LevelPass && player.XPlayer == DoorX && player.YPlayer == DoorY)
            {
                LevelPass = false;
                Form.NextLevel();
            }
        }
    }
}