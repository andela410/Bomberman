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
            KeyDown += new KeyEventHandler(Form1_KeyDown);
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
            enemy = new Enemy(this, game, 3, 3, "left");
            enemy.Move();
            
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
                //Do here
                player.Move("left");
                e.Handled = true;
            }
            if (e.KeyCode == Keys.D)
            { 
                player.Move("right");
            }
            if (e.KeyCode == Keys.W)
            {
                player.Move("up");
            }
            if (e.KeyCode == Keys.S)
            {
                player.Move("down");
            }
            if(e.KeyCode == Keys.B) //Pusti bombu na tipku B
            {
                Bomb bomb = new Bomb(this, game, player, brick, player.XPlayer, player.YPlayer);
                bomb.PlantBomb();
            }
        }
    }
}
