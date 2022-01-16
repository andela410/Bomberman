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
        public static Classes.Player player;
        public static Classes.GameField game = new Classes.GameField();
        public static Classes.Brick brick = new Classes.Brick(player);

        public Form1()
        {
            InitializeComponent();
            SetupGame();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPreview = true;
        }

        void SetupGame()
        {
            game.CreateGameField(this);
            game.InitializeGameField(1);
            brick.CreateBrickWalls(this, game);
            player = new Classes.Player(this, game, 2, 1);
            player.CreateLives(this);
            player.CreatePlayerScore(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.GetLife();
            //player.UpdateScore(100);

            //brick.DestroyBrickWall(this, 1, 3);

            Classes.Bomb bomb = new Classes.Bomb(this, game, player, 3, 5);
            bomb.PlantBomb();
            //bomb.PlantBomb(this, game, 11, 1);
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
                Classes.Bomb bomb = new Classes.Bomb(this, game, player, player.XPlayer, player.YPlayer);
                bomb.PlantBomb();
            }
        }
    }
}
