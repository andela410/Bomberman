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
        Enemy enemy;

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
            enemy = new Enemy(this, game, 3, 3, "left", player);
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
                Bomb bomb = new Bomb(this, game, player, enemy, brick, player.XPlayer, player.YPlayer);
                bomb.PlantBomb();
                player.BringPicToFront();
            }

            /*keyUp = false;
            Stopwatch sw = new Stopwatch();
            while (keyUp == false)
            {
                if (sw.ElapsedMilliseconds < 100) player.Move();
            }*/

        }
        //private Boolean keyUp = false;
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

    }
}
