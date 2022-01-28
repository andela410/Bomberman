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
    public partial class Form1 : Form
    {
        GameField game;
        Player player;
        Brick brick;
        List<Enemy> enemies;
        public Label youDied;

        public Form1(int level, int player_number)
        {
            InitializeComponent();
            SetupGame(level, player_number);
            KeyPreview = true;
        }

        void SetupGame(int level, int player_number)
        {
            game = new GameField(this);
            game.CreateGameField(level, player_number);
            game.InitializeGameField(level);
            
            brick = new Brick(this, game);
            brick.CreateBrickWalls();
            
            player = new Player(this, game, 1, 1, player_number);
            player.CreateLives();
            player.CreatePlayerScore();

            SetupEnemies(level);
            //enemy = new Enemy(this, game, 3, 3, "left", player);
            //enemy.EnemyMoved += player.CheckIfEnemyHit;
            //player.PlayerMoved += enemy.CheckIfPlayerHit;

            setupGameTimer();
            startGameTimer();
        }
        private void SetupEnemies(int level)
        {
            enemies = new List<Enemy>();
            Enemy enemy;
            switch (level)
            {
                case 1:
                    enemies.Add(new Enemy(this, game, 3, 14, 1, "left", player));
                    enemies.Add(new Enemy(this, game, 5, 20, 1, "right", player));
                    enemies.Add(new Enemy(this, game, 11, 21, 1, "left", player));
                    enemies.Add(new Enemy(this, game, 11, 27, 1, "left", player));
                    break;
                case 2:
                    enemies.Add(new Enemy(this, game, 1, 11, 2, "left", player));
                    enemies.Add(new Enemy(this, game, 7, 9, 1, "right", player));
                    enemies.Add(new Enemy(this, game, 3, 12, 2, "left", player));
                    enemies.Add(new Enemy(this, game, 6, 13, 2, "left", player));
                    enemies.Add(new Enemy(this, game, 11, 28, 1, "left", player));
                    break;
                case 3:
                    enemies.Add(new Enemy(this, game, 6, 11, 3, "left", player));
                    enemies.Add(new Enemy(this, game, 3, 15, 2, "right", player));
                    enemies.Add(new Enemy(this, game, 4, 21, 1, "left", player));
                    enemies.Add(new Enemy(this, game, 1, 21, 1, "left", player));
                    enemies.Add(new Enemy(this, game, 11, 21, 1, "left", player));
                    enemies.Add(new Enemy(this, game, 11, 26, 1, "right", player));
                    enemies.Add(new Enemy(this, game, 11, 28, 2, "left", player));
                    break;
                case 4:
                    enemies.Add(new Enemy(this, game, 5, 7, 1, "left", player));
                    enemies.Add(new Enemy(this, game, 7, 23, 2, "right", player));
                    enemies.Add(new Enemy(this, game, 3, 21, 1, "left", player));
                    enemies.Add(new Enemy(this, game, 7, 2, 1, "left", player));
                    enemies.Add(new Enemy(this, game, 5, 25, 1, "left", player));
                    enemies.Add(new Enemy(this, game, 1, 19, 1, "right", player));
                    enemies.Add(new Enemy(this, game, 8, 28, 3, "left", player));
                    enemies.Add(new Enemy(this, game, 11, 25, 3, "left", player));
                    break;
                case 5:
                    enemies.Add(new Enemy(this, game, 1, 4, 3, "left", player));
                    enemies.Add(new Enemy(this, game, 1, 6, 3, "right", player));
                    enemies.Add(new Enemy(this, game, 1, 7, 3, "left", player));
                    enemies.Add(new Enemy(this, game, 3, 4, 3, "left", player));
                    enemies.Add(new Enemy(this, game, 3, 10, 3, "left", player));
                    enemies.Add(new Enemy(this, game, 5, 17, 3, "right", player));
                    enemies.Add(new Enemy(this, game, 11, 17, 3, "left", player));
                    enemies.Add(new Enemy(this, game, 11, 16, 3, "left", player));
                    enemies.Add(new Enemy(this, game, 1, 24, 3, "left", player));
                    enemies.Add(new Enemy(this, game, 6, 28, 3, "left", player));
                    break;
                default:
                    break;
            }
            foreach(Enemy en in enemies)
            {
                en.EnemyMoved += player.CheckIfEnemyHit;
                player.PlayerMoved += en.CheckIfPlayerHit;
            }

        }

        private void closeGame_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (!player.goleft)
                {
                    player.goleft = true;
                    player.Move();
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (!player.goright)
                {
                    player.goright = true;
                    player.Move();
                }
            }
            if (e.KeyCode == Keys.W)
            {
                if (!player.goup)
                {
                    player.goup = true;
                    player.Move();
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (!player.godown)
                {
                    player.godown = true;
                    player.Move();
                }
            }
            if (e.KeyCode == Keys.B) //Pusti bombu na tipku B
            {
                Bomb bomb = new Bomb(this, game, player, enemies, brick, player.XPlayer, player.YPlayer);
                bomb.PlantBomb();
                player.BringPicToFront();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //keyUp = true;
            if (e.KeyCode == Keys.A)
            {
                player.goleft = false;
                player.MoveStop();
            }
            if (e.KeyCode == Keys.D)
            {
                player.goright = false;
                player.MoveStop();
            }
            if (e.KeyCode == Keys.W)
            {
                player.goup = false;
                player.MoveStop();
            }
            if (e.KeyCode == Keys.S)
            {
                player.godown = false;
                player.MoveStop();
            }
        }

        Label TimeLabel;
        Label TimeStaticString;
        Timer gameTimer;
        int secondsCounter;
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
            this.Controls.Add(TimeStaticString);
            TimeStaticString.BringToFront();

            TimeLabel = new Label();
            TimeLabel.ForeColor = Color.White;
            TimeLabel.Font = new Font("Folio XBd BT", 14);
            TimeLabel.Top = 40 + 30 + game.GameFieldHeight * game.ElementSize;
            TimeLabel.Left = 40 + TimeLabel.Width - 40;
            TimeLabel.Height = 25;
            TimeLabel.Width = 100;
            this.Controls.Add(TimeLabel);
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

    }
}
