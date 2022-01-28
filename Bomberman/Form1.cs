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
        Enemy enemy;
        PlayerKeys P1keys;
        PlayerKeys P2keys;
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
            player1 = new Player(this, game, 1, 1, player_number, P1keys);
            player1.CreateLives();
            player1.CreatePlayerScore();
            enemy = new Enemy(this, game, 3, 3, "left", player1);
            enemy.EnemyMoved += player1.CheckIfEnemyHit;
            player1.Enemy = enemy;
            player1.Brick = brick;
            player1.PlayerMoved += enemy.CheckIfPlayerHit;
            KeyDown += player1.OnKeyDown;
            //KeyDown += player2.OnKeyDown;
            KeyUp += player1.OnKeyUp;
            //KeyUp += player2.OnKeyUp;
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
