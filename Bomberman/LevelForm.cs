using Bomberman.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bomberman
{
    public partial class LevelForm : Form
    {
        GameField game;
        Player player1;
        Player player2;
        PlayerKeys P1keys;
        PlayerKeys P2keys;
        List<Enemy> Enemies;
        int PlayerNumber1;
        int PlayerNumber2;
        Label ScoreTextLabel;
        private static int TotalScore = 0;
        Label TimeLabel;
        Label TimeStaticString;
        Timer gameTimer;
        int secondsCounter;

        public int Level { get; private set; }

        public int GameMode { get; }

        public int PlayerCnt
        {
            get; set;
        }

        public LevelForm(int tmpLevel, int player_number1, int player_number2, int game_mode, PlayerKeys p1keys, PlayerKeys p2keys)
        {
            InitializeComponent();
            KeyPreview = true;
            Level = tmpLevel;
            PlayerNumber1 = player_number1;
            PlayerNumber2 = player_number2;
            GameMode = game_mode;
            P1keys = p1keys;
            P2keys = p2keys;
            SetupGame(Level);
        }

        void SetupGame(int level)
        {
            game = new GameField(this);
            game.CreateGameField(level);
            game.InitializeGameField(level);

            Brick brick = new Brick(this, game);
            brick.CreateBrickWalls();

            player1 = new Player(this, game, 1, 1, PlayerNumber1, P1keys);
            player1.CreateLives(0);
            player1.Brick = brick;
            PlayerCnt = 1;
            Player.PlayerMoved += game.CheckIfLevelPassed;
            Bomb.BombExploadedEvent += player1.CheckIfHit;

            KeyDown += player1.OnKeyDown;
            KeyUp += player1.OnKeyUp;

            if (GameMode == 3)
            {
                player2 = new Player(this, game, 1, 2, PlayerNumber2, P2keys);
                player2.CreateLives(1);
                player2.Brick = brick;

                KeyDown += player2.OnKeyDown;
                KeyUp += player2.OnKeyUp;

                PlayerCnt = 2;
            }

            CreateScoreLabel();
            SetupEnemies(level);

            if (GameMode == 3)
            {
                Bomb.BombExploadedEvent += player2.CheckIfHit;
            }

            setupGameTimer();
            startGameTimer();
        }

        private void SetupEnemies(int level)
        {
            Enemies = new List<Enemy>();

            switch (level)//ovo dodavanje enemya isto ne smije biti u formi nego odvojeno, npr. nova klasa level u koji onda ovo napravimo
            {
                case 1:
                    Enemies.Add(new Enemy(this, game, 3, 14, 1, "left"));
                    Enemies.Add(new Enemy(this, game, 5, 20, 1, "right"));
                    Enemies.Add(new Enemy(this, game, 11, 21, 1, "left"));
                    Enemies.Add(new Enemy(this, game, 11, 27, 1, "left"));
                    break;
                case 2:
                    Enemies.Add(new Enemy(this, game, 1, 11, 2, "left"));
                    Enemies.Add(new Enemy(this, game, 7, 9, 1, "right"));
                    Enemies.Add(new Enemy(this, game, 3, 12, 2, "left"));
                    Enemies.Add(new Enemy(this, game, 6, 13, 2, "left"));
                    Enemies.Add(new Enemy(this, game, 11, 28, 1, "left"));
                    break;
                case 3:
                    Enemies.Add(new Enemy(this, game, 6, 11, 3, "left"));
                    Enemies.Add(new Enemy(this, game, 3, 15, 2, "right"));
                    Enemies.Add(new Enemy(this, game, 4, 21, 1, "left"));
                    Enemies.Add(new Enemy(this, game, 1, 21, 1, "left"));
                    Enemies.Add(new Enemy(this, game, 11, 21, 1, "left"));
                    Enemies.Add(new Enemy(this, game, 11, 26, 1, "right"));
                    Enemies.Add(new Enemy(this, game, 11, 28, 2, "left"));
                    break;
                case 4:
                    Enemies.Add(new Enemy(this, game, 5, 7, 1, "left"));
                    Enemies.Add(new Enemy(this, game, 7, 23, 2, "right"));
                    Enemies.Add(new Enemy(this, game, 3, 21, 1, "left"));
                    Enemies.Add(new Enemy(this, game, 7, 2, 1, "left"));
                    Enemies.Add(new Enemy(this, game, 5, 25, 1, "left"));
                    Enemies.Add(new Enemy(this, game, 1, 19, 1, "right"));
                    Enemies.Add(new Enemy(this, game, 8, 28, 3, "left"));
                    Enemies.Add(new Enemy(this, game, 11, 25, 3, "left"));
                    break;
                case 5:
                    Enemies.Add(new Enemy(this, game, 1, 4, 3, "left"));
                    Enemies.Add(new Enemy(this, game, 1, 6, 3, "right"));
                    Enemies.Add(new Enemy(this, game, 1, 7, 3, "left"));
                    Enemies.Add(new Enemy(this, game, 3, 4, 3, "left"));
                    Enemies.Add(new Enemy(this, game, 3, 10, 3, "left"));
                    Enemies.Add(new Enemy(this, game, 5, 17, 3, "right"));
                    Enemies.Add(new Enemy(this, game, 11, 17, 3, "left"));
                    Enemies.Add(new Enemy(this, game, 11, 16, 3, "left"));
                    Enemies.Add(new Enemy(this, game, 1, 24, 3, "left"));
                    Enemies.Add(new Enemy(this, game, 6, 28, 3, "left"));
                    break;
                default:
                    break;
            }

            Enemy.EnemyMoved += player1.CheckIfHit;
            foreach (Enemy en in Enemies)
            {
                Player.PlayerMoved += en.CheckIfPlayerHit;
                Bomb.BombExploadedEvent += en.CheckIfHit;
            }

        }

        public void NextLevel()
        {
            //Dispose();
            if (Level == 5 || GameMode != 1)
            {
                // kraj
                Form gameOver = new GameOver(TotalScore, GameMode, Level);
                TotalScore = 0;
                Hide();
                gameOver.Closed += (s, args) => { Close(); Dispose(); };
                gameOver.Show();
                return;

            }
            if (GameMode == 1) //campaign
            {
                CleanUp();
                Close();
                Dispose();
                Form NextLevelForm = new LevelForm(++Level, PlayerNumber1, PlayerNumber2, GameMode, P1keys, P2keys);
                NextLevelForm.Show();
                NextLevelForm.Closed += (s, args) => {
                    NextLevelForm.Show();
                    NextLevelForm.Dispose();
                };
            }
        }

        public void GameOver()
        {
            youDiedScreen();
            Form gameOver = new GameOver(TotalScore, GameMode, Level);
            TotalScore = 0;
            CleanUp();
            Close();

            gameOver.Closed += (s, args) => { Close(); Dispose(); };
            gameOver.Show();
        }

        private void closeGame_Click(object sender, EventArgs e)
        {
            CleanUp();
            Close();
            TotalScore = 0;
            Dispose();
        }

        public void SetPlayersKeys(Tuple<PlayerKeys, PlayerKeys> tup)
        {
            player1.PlayerKeys = tup.Item1;
            player2.PlayerKeys = tup.Item2;
        }

        private void setupGameTimer()
        {
            TimeStaticString = new Label();
            TimeStaticString.ForeColor = Color.White;
            TimeStaticString.Font = new Font("Folio XBd BT", 14);
            TimeStaticString.Top = 40 + 30 + game.GameFieldHeight * game.ElementSize;
            TimeStaticString.Left = 40;
            TimeStaticString.Height = 25;
            TimeStaticString.Width = 100;
            TimeStaticString.Text = "Time: ";
            Controls.Add(TimeStaticString);
            TimeStaticString.BringToFront();

            TimeLabel = new Label();
            TimeLabel.ForeColor = Color.White;
            TimeLabel.Font = new Font("Folio XBd BT", 14);
            TimeLabel.Top = 40 + 30 + game.GameFieldHeight * game.ElementSize;
            TimeLabel.Left = 40 + TimeLabel.Width - 40;
            TimeLabel.Height = 25;
            TimeLabel.Width = 100;
            Controls.Add(TimeLabel);
            TimeLabel.BringToFront();

            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += new EventHandler(gameTimerUpdate);

        }

        private void startGameTimer()
        {
            gameTimer.Enabled = true;
        }

        private void gameTimerUpdate(object sender, EventArgs e)
        {
            secondsCounter++;
            TimeLabel.Text = secondsCounter.ToString() + " sec";
        }

        public void CreateScoreLabel()
        {
            // Create score label
            ScoreTextLabel = new Label();
            ScoreTextLabel.ForeColor = Color.White;
            ScoreTextLabel.Font = new Font("Folio XBd BT", 14);
            ScoreTextLabel.Top = 10;
            ScoreTextLabel.Left = Width / 2 - 50;
            ScoreTextLabel.Height = 20;
            ScoreTextLabel.Width = 100;
            Controls.Add(ScoreTextLabel);
            ScoreTextLabel.BringToFront();
            UpdateTotalScore();
        }


        public void UpdateTotalScore(int amount = 0)
        {
            // Update score value and text
            //score += amount;
            TotalScore += amount;
            ScoreTextLabel.Text = TotalScore.ToString();
            //if (score > Form1.highscore.score) { Form1.highscore.UpdateHighScore(score); }
        }
        public void youDiedScreen()
        {
            SuspendLayout();
            Label youDied = new Label();
            youDied.Text = "YOU DIED";
            youDied.ForeColor = Color.Maroon;
            youDied.Font = new Font("Franklin Gothic Medium", 50, FontStyle.Bold);
            youDied.BackColor = Color.Black;
            youDied.Visible = true;
            youDied.AutoSize = true;
            youDied.Location = new Point(Width / 2 - youDied.Width / 2, Height / 2 - youDied.Height / 2);
            Controls.Add(youDied);
            youDied.BringToFront();
            ResumeLayout();
            for (int i = 50; i < 100; ++i)
            {
                youDied.Font = new Font("Franklin Gothic Medium", i, FontStyle.Bold);
                youDied.Location = new Point(Width / 2 - youDied.Width / 2, Height / 2 - youDied.Height / 2);
                youDied.Refresh();
                System.Threading.Thread.Sleep(50);
            }
            System.Threading.Thread.Sleep(1000);
        }

        public void CleanUp()
        {
            gameTimer.Tick -= new EventHandler(gameTimerUpdate);
            gameTimer.Dispose();
            Enemy.EnemyMoved -= player1.CheckIfHit;
            Bomb.BombExploadedEvent -= player1.CheckIfHit;

            if (GameMode == 3)
            {
                Enemy.EnemyMoved -= player2.CheckIfHit;
                Bomb.BombExploadedEvent -= player2.CheckIfHit;
            }

            for (int i = 0; i < Enemies.Count(); ++i)
            {
                Player.PlayerMoved -= Enemies[i].CheckIfPlayerHit;
                Bomb.BombExploadedEvent -= Enemies[i].CheckIfHit;
                Enemies[i].CleanUp();
                Enemies[i] = null;
            }


            Enemies.Clear();      
            Player.Score = 0;
            PlayerCnt = 0;
            Enemy.enemyCnt = 0;
        }
    }
}
