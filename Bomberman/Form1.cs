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
        Player player1;
        Player player2;
        Brick brick;
        PlayerKeys P1keys;
        PlayerKeys P2keys;
        List<Enemy> Enemies;
        public Label youDied;

        public Form1(int level, int player_number, PlayerKeys p1keys, PlayerKeys p2keys)
        {
            InitializeComponent();
            KeyPreview = true;
            P1keys = p1keys;
            P2keys = p2keys;
            SetupGame(level, player_number);
        }

        void SetupGame(int level, int player_number)
        {
            game = new GameField(this);
            game.CreateGameField(level, player_number);
            game.InitializeGameField(level);
            
            brick = new Brick(this, game);
            brick.CreateBrickWalls();

            player1 = new Player(this, game, 1, 1, player_number, P1keys, Enemies);
            player1.CreateLives();
            player1.CreatePlayerScore();
            player1.Brick = brick;

            KeyDown += player1.OnKeyDown;
            //KeyDown += player2.OnKeyDown;
            KeyUp += player1.OnKeyUp;
            //KeyUp += player2.OnKeyUp;

            SetupEnemies(level);

            player1.Enemies = Enemies;

            //setupGameTimer();
            //startGameTimer();
        }
        private void SetupEnemies(int level)
        {
            Enemies = new List<Enemy>();
            Enemy enemy;
            switch (level)//ovo dodavanje enemya isto ne smije biti u formi nego odvojeno, npr. nova klasa level u koji onda ovo napravimo
            {
                case 1:
                    Enemies.Add(new Enemy(this, game, 3, 14, 1, "left", player1));
                    Enemies.Add(new Enemy(this, game, 5, 20, 1, "right", player1));
                    Enemies.Add(new Enemy(this, game, 11, 21, 1, "left", player1));
                    Enemies.Add(new Enemy(this, game, 11, 27, 1, "left", player1));
                    break;
                case 2:
                    Enemies.Add(new Enemy(this, game, 1, 11, 2, "left", player1));
                    Enemies.Add(new Enemy(this, game, 7, 9, 1, "right", player1));
                    Enemies.Add(new Enemy(this, game, 3, 12, 2, "left", player1));
                    Enemies.Add(new Enemy(this, game, 6, 13, 2, "left", player1));
                    Enemies.Add(new Enemy(this, game, 11, 28, 1, "left", player1));
                    break;
                case 3:
                    Enemies.Add(new Enemy(this, game, 6, 11, 3, "left", player1));
                    Enemies.Add(new Enemy(this, game, 3, 15, 2, "right", player1));
                    Enemies.Add(new Enemy(this, game, 4, 21, 1, "left", player1));
                    Enemies.Add(new Enemy(this, game, 1, 21, 1, "left", player1));
                    Enemies.Add(new Enemy(this, game, 11, 21, 1, "left", player1));
                    Enemies.Add(new Enemy(this, game, 11, 26, 1, "right", player1));
                    Enemies.Add(new Enemy(this, game, 11, 28, 2, "left", player1));
                    break;
                case 4:
                    Enemies.Add(new Enemy(this, game, 5, 7, 1, "left", player1));
                    Enemies.Add(new Enemy(this, game, 7, 23, 2, "right", player1));
                    Enemies.Add(new Enemy(this, game, 3, 21, 1, "left", player1));
                    Enemies.Add(new Enemy(this, game, 7, 2, 1, "left", player1));
                    Enemies.Add(new Enemy(this, game, 5, 25, 1, "left", player1));
                    Enemies.Add(new Enemy(this, game, 1, 19, 1, "right", player1));
                    Enemies.Add(new Enemy(this, game, 8, 28, 3, "left", player1));
                    Enemies.Add(new Enemy(this, game, 11, 25, 3, "left", player1));
                    break;
                case 5:
                    Enemies.Add(new Enemy(this, game, 1, 4, 3, "left", player1));
                    Enemies.Add(new Enemy(this, game, 1, 6, 3, "right", player1));
                    Enemies.Add(new Enemy(this, game, 1, 7, 3, "left", player1));
                    Enemies.Add(new Enemy(this, game, 3, 4, 3, "left", player1));
                    Enemies.Add(new Enemy(this, game, 3, 10, 3, "left", player1));
                    Enemies.Add(new Enemy(this, game, 5, 17, 3, "right", player1));
                    Enemies.Add(new Enemy(this, game, 11, 17, 3, "left", player1));
                    Enemies.Add(new Enemy(this, game, 11, 16, 3, "left", player1));
                    Enemies.Add(new Enemy(this, game, 1, 24, 3, "left", player1));
                    Enemies.Add(new Enemy(this, game, 6, 28, 3, "left", player1));
                    break;
                default:
                    break;
            }
            foreach(Enemy en in Enemies)
            {
                en.EnemyMoved += player1.CheckIfEnemyHit;
                player1.PlayerMoved += en.CheckIfPlayerHit;
            }

        }

        private void closeGame_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        public void SetPlayersKeys(Tuple<PlayerKeys, PlayerKeys> tup)
        {
            player1.playerKeys = tup.Item1;
            player2.playerKeys = tup.Item2;
        }
    }
}
