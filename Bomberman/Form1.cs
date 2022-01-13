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
        public static Classes.Player player = new Classes.Player();
        public static Classes.GameField game = new Classes.GameField();
        public static Classes.Brick brick = new Classes.Brick();


        public Form1()
        {
            InitializeComponent();
            SetupGame();
        }

        void SetupGame()
        {
            player.CreateLives(this);
            player.CreatePlayerScore(this);
            game.CreateGameField(this);
            game.InitializeGameField(1);
            brick.CreateBrickWalls(this, game);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.GetLife();
            player.UpdateScore(100);

            //brick.DestroyBrickWall(this, 1, 3);

            Classes.Bomb bomb = new Classes.Bomb(this, game, 3, 5);
            bomb.PlantBomb();
            //bomb.PlantBomb(this, game, 11, 1);
        }
    }
}
