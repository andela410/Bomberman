﻿using System;
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
        private static int PlayerCnt = 0;
        public int Lives = 3;
        public int Score = 0;
        public Label ScoreText = new Label();
        public PictureBox[] LifeImage = new PictureBox[MaxLives];
        private int xPlayer, yPlayer;
        GameField Field;
        Form1 Form;
        PictureBox playerPicture;
        Timer MoveTimer;
        bool Alive;

        public int XPlayer
        {
            get { return xPlayer; }
        }

        public int YPlayer
        {
            get { return yPlayer; }
        }

        public Boolean goleft
        {
            get; set;
        }

        public Boolean goright
        {
            get; set;
        }
        public Boolean goup
        {
            get; set;
        }
        public Boolean godown
        {
            get; set;
        }

        public Player(Form1 form, GameField field, int x, int y, int player_number)
        {
            xPlayer = x;
            yPlayer = y;
            Field = field;
            Form = form;

            playerPicture = new PictureBox();

            SetPlayer(x, y, player_number);

            MoveTimer = new Timer();
            MoveTimer.Interval = 250;
            MoveTimer.Tick += new EventHandler(MoveTimer_Tick);
            PlayerCnt++;
            Alive = true;
        }

        public void CheckIfEnemyHit(Enemy enemy)
        {
            if (xPlayer == enemy.XEnemy && yPlayer == enemy.YEnemy) LoseLife();
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
            for (int x = 0; x < Lives; ++x)
            {
                LifeImage[x].Visible = true;
            }
            for (int x = Lives; x < MaxLives; ++x)
            {
                LifeImage[x].Visible = false;
            }
        }

        public void LoseLife()
        {
            // Lose a life
            if (Lives > 0) Lives--;
            else return;

            if (Lives == 0)
            {
                Alive = false;
                PlayerCnt--;
            }
            else if (Lives > 0)
            {
                SetLives();
            }

            if(PlayerCnt == 0)
            {
                Form gameOver = new GameOver();
                gameOver.Show();
                Form.Hide();
                gameOver.Closed += (s, args) => Form.Close();
                gameOver.Show();
            }
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

        private void SetPlayer(int x, int y, int player_number) //pozovi u konstruktoru
        {

            //PictureBox e = new PictureBox();
            // e.Name = "Fire" + x.ToString() + y.ToString();

            playerPicture.Name = "Player" + xPlayer.ToString() + yPlayer.ToString();
            playerPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            playerPicture.Location = new Point(x * Field.ElementSize + Field.PictureBox.Location.X, y * Field.ElementSize + Field.PictureBox.Location.Y);
            Bitmap Player_transparent = new Bitmap(Properties.Resources.Player1);
            switch (player_number)
            {
                case 1:
                    Player_transparent = new Bitmap(Properties.Resources.Player1);
                    break;
                case 2:
                    Player_transparent = new Bitmap(Properties.Resources.Player2);
                    break;
                case 3:
                    Player_transparent = new Bitmap(Properties.Resources.Player3);
                    break;
                case 4:
                    Player_transparent = new Bitmap(Properties.Resources.Player4);
                    break;
                default:
                    break;
            }

            Player_transparent.MakeTransparent(Color.White);
            playerPicture.Image = Player_transparent;
            Form.Controls.Add(playerPicture);

            playerPicture.BringToFront();
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void Move()
        {
            if (!Alive) return;
            MoveTimer.Enabled = true;
            if (goleft == true)
            {
                if (Field.Field[xPlayer, yPlayer - 1] != 'w' && Field.Field[xPlayer, yPlayer - 1] != 'b' && Field.Field[xPlayer, yPlayer - 1] != 'h')
                {
                    yPlayer--;
                }
            }
            else if (goright == true)
            {
                if (Field.Field[xPlayer, yPlayer + 1] != 'w' && Field.Field[xPlayer, yPlayer + 1] != 'b' && Field.Field[xPlayer, yPlayer + 1] != 'h')
                {
                    yPlayer++;
                }
            }
            else if (godown == true)
            {
                if (Field.Field[xPlayer + 1, yPlayer] != 'w' && Field.Field[xPlayer + 1, yPlayer] != 'b' && Field.Field[xPlayer + 1, yPlayer] != 'h')
                {
                    xPlayer++;
                }
            }
            else if (goup == true)
            {
                if (Field.Field[xPlayer - 1, yPlayer] != 'w' && Field.Field[xPlayer - 1, yPlayer] != 'b' && Field.Field[xPlayer - 1, yPlayer] != 'h')
                {
                    xPlayer--;
                }
            }

            playerPicture.Location = new Point(yPlayer * Field.ElementSize + Field.PictureBox.Location.X, xPlayer * Field.ElementSize + Field.PictureBox.Location.Y);
            Form.Controls.Add(playerPicture);

            playerPicture.BringToFront();
            PlayerMoved?.Invoke(this);
        }

        public void MoveStop()
        {
            MoveTimer.Enabled = false;
        }

        public void BringPicToFront()
        {
            playerPicture.BringToFront();
        }

        public event Action<Player> PlayerMoved;
    }
}
