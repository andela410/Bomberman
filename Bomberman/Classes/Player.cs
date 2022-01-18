using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace Bomberman.Classes
{
    public class Player
    {
        private const int MaxLives = 10;
        public int Lives = 3;
        public int Score = 0;
        public Label ScoreText = new Label();
        public PictureBox[] LifeImage = new PictureBox[MaxLives];
        private int xPlayer, yPlayer;
        GameField Field;
        Form Form;
        PictureBox playerPicture;

        public int XPlayer
        {
            get { return xPlayer; }
        }

        public int YPlayer
        {
            get { return yPlayer; }
        }

        public Player(Form form, GameField field, int x, int y)
        {
            xPlayer = x;
            yPlayer = y;
            Field = field;
            Form = form;

            playerPicture = new PictureBox();

            SetPlayer(x, y);
        }

        public void CreateLives()
        {
            for (int x = 0; x < MaxLives; x++)
            {
                LifeImage[x] = new PictureBox();
                LifeImage[x].Name = "Life" + x.ToString();
                LifeImage[x].SizeMode = PictureBoxSizeMode.AutoSize;
                LifeImage[x].Location = new Point(x * 22 + 15, 10);
                LifeImage[x].Image = Properties.Resources.Life;
                Form.Controls.Add(LifeImage[x]);
                LifeImage[x].BringToFront();
            }
            SetLives();
        }

        public void CreatePlayerScore()
        {
            // Create Score label
            ScoreText.ForeColor = Color.White;
            ScoreText.Font = new Font("Folio XBd BT", 14);
            ScoreText.Top = 10;
            ScoreText.Left = Form.Width / 2 - 50;
            ScoreText.Height = 20;
            ScoreText.Width = 100;
            ScoreText.BringToFront();
            UpdateScore(0);
        }

        void SetLives()
        {
            // Display lives in form
            for (int x = 0; x < Lives; x++)
            {
                LifeImage[x].Visible = true;
            }
            for (int x = Lives; x < MaxLives; x++)
            {
                LifeImage[x].Visible = false;
            }
        }

        public void LoseLife()
        {
            // Lose a life
            Lives--;

            if (Lives <= 0)
            {
                Application.Exit();
            }
            SetLives();
        }

        public void GetLife()
        {
            // Get a life
            if (Lives < MaxLives)
            {
                Lives++;
                SetLives();
            }
        }

        public void UpdateScore(int amount = 1)
        {
            // Update score value and text
            Score += amount;
            ScoreText.Text = Score.ToString();
            //if (Score > Form1.highscore.Score) { Form1.highscore.UpdateHighScore(Score); }
        }

        private void SetPlayer(int x, int y) //pozovi u konstruktoru
        {

            //PictureBox e = new PictureBox();
            // e.Name = "Fire" + x.ToString() + y.ToString();

            playerPicture.Name = "Player" + xPlayer.ToString() + yPlayer.ToString();
            playerPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            playerPicture.Location = new Point(x * Field.ElementSize + Field.PictureBox.Location.X, y * Field.ElementSize + Field.PictureBox.Location.Y);
            Bitmap Enemy_bitmap = new Bitmap(Properties.Resources.Enemy);
            Enemy_bitmap.MakeTransparent(Color.White);
            playerPicture.Image = Enemy_bitmap;
            Form.Controls.Add(playerPicture);

            playerPicture.BringToFront();
        }

        public void Move(string direction)
        {
            if(direction == "left")
            {
                //MessageBox.Show("pomak lijevo");
                if (/*yPlayer - 1 > 0 && */Field.Field[xPlayer, yPlayer - 1] != 'w' && Field.Field[xPlayer, yPlayer - 1] != 'b')
                {
                    yPlayer--;
                }
            }
            else if (direction == "right")
            {
                //MessageBox.Show("pomak desno");
                if (/*yPlayer - 1 <  Field.GameFieldWidth && */Field.Field[xPlayer, yPlayer + 1] != 'w' && Field.Field[xPlayer, yPlayer + 1] != 'b')
                {
                    yPlayer++;
                }
            }
            else if (direction == "down")
            {
                //MessageBox.Show("pomak gore");
                if (/*xPlayer + 1 < Field.GameFieldHeight && */Field.Field[xPlayer + 1, yPlayer] != 'w' && Field.Field[xPlayer + 1, yPlayer] != 'b')
                {
                    xPlayer++;
                }
            }
            else if (direction == "up")
            {
                //MessageBox.Show("pomak dolje");
                if (/*xPlayer - 1 > 0 && */Field.Field[xPlayer - 1, yPlayer] != 'w' && Field.Field[xPlayer - 1, yPlayer] != 'b')
                {
                    xPlayer--;
                }
            }
            playerPicture.Location = new Point(yPlayer * Field.ElementSize + Field.PictureBox.Location.X, xPlayer * Field.ElementSize + Field.PictureBox.Location.Y);
            Form.Controls.Add(playerPicture);

            playerPicture.BringToFront();
        }
    }
}
