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

        public void CreateLives(Form formInstance)
        {
            for (int x = 0; x < MaxLives; x++)
            {
                LifeImage[x] = new PictureBox();
                LifeImage[x].Name = "Life" + x.ToString();
                LifeImage[x].SizeMode = PictureBoxSizeMode.AutoSize;
                LifeImage[x].Location = new Point(x * 22 + 15, 10);
                LifeImage[x].Image = Properties.Resources.Life;
                formInstance.Controls.Add(LifeImage[x]);
                LifeImage[x].BringToFront();
            }
            SetLives();
        }

        public void CreatePlayerScore(Form formInstance)
        {
            // Create Score label
            ScoreText.ForeColor = Color.White;
            ScoreText.Font = new System.Drawing.Font("Folio XBd BT", 14);
            ScoreText.Top = 10;
            ScoreText.Left = formInstance.Width / 2 - 50;
            ScoreText.Height = 20;
            ScoreText.Width = 100;
            formInstance.Controls.Add(ScoreText);
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
        public void Move(string direction)//treba paziti i da enemy i igrac ne mogu proci jedan kroz drugoga
        {                                   //ovo bi se moglo dogoditi ako su jedan kraj drugog i onda izvrse provjeru istovremeno
            if(direction == "left")
            {
                //MessageBox.Show("pomak lijevo");
                if (xPlayer - 1 > 0 && Field.Field[yPlayer, xPlayer - 1] != 'w' && Field.Field[yPlayer, xPlayer - 1] != 'b')
                {
                    --xPlayer;
                }
                playerPicture.Location = new Point(xPlayer * Field.ElementSize + Field.PictureBox.Location.X, yPlayer * Field.ElementSize + Field.PictureBox.Location.Y);
                Form.Controls.Add(playerPicture);

                playerPicture.BringToFront();
            }
            if (direction == "right")
            {
                //MessageBox.Show("pomak desno");
                if (/*xPlayer + 1 > 0 && */Field.Field[yPlayer, xPlayer + 1] != 'w' && Field.Field[yPlayer, xPlayer + 1] != 'b')
                {
                    ++xPlayer;
                }
                playerPicture.Location = new Point(xPlayer * Field.ElementSize + Field.PictureBox.Location.X, yPlayer * Field.ElementSize + Field.PictureBox.Location.Y);
                Form.Controls.Add(playerPicture);

                playerPicture.BringToFront();
            }
            if (direction == "down")
            {
                //MessageBox.Show("pomak dolje");
                if (/*yPlayer + 1 > 0 && */Field.Field[yPlayer + 1, xPlayer] != 'w' && Field.Field[yPlayer + 1, xPlayer] != 'b')
                {
                    ++yPlayer;
                }
                playerPicture.Location = new Point(xPlayer * Field.ElementSize + Field.PictureBox.Location.X, yPlayer * Field.ElementSize + Field.PictureBox.Location.Y);
                Form.Controls.Add(playerPicture);

                playerPicture.BringToFront();
            }
            if (direction == "up")
            {
                //MessageBox.Show("pomak gore");
                if (yPlayer - 1 > 0 && Field.Field[yPlayer - 1, xPlayer] != 'w' && Field.Field[yPlayer - 1, xPlayer] != 'b')
                {
                    --yPlayer;
                }
                playerPicture.Location = new Point(xPlayer * Field.ElementSize + Field.PictureBox.Location.X, yPlayer * Field.ElementSize + Field.PictureBox.Location.Y);
                Form.Controls.Add(playerPicture);

                playerPicture.BringToFront();
            }


        }
    }
}
