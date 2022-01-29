using System;
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
        static int PlayerCnt = 0;
        public int Lives = 3;
        public static int Score = 0;
        public int MaxLevel = 1;
        public static Label ScoreText = new Label();
        public PictureBox[] LifeImage = new PictureBox[MaxLives];
        private int xPlayer, yPlayer;
        GameField Field;
        LevelForm Form;
        PictureBox playerPicture;
        List<Enemy> enemies;
        Timer MoveTimer;
        bool Alive;

        public Brick Brick 
        {
            get; set;
        }

        public Enemy Enemy
        {
            get; set;
        }

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

        public List<Enemy> Enemies
        {
            get { return enemies; }
            set { enemies = value; }
        }

        public PlayerKeys playerKeys { get; set; }

        public Player(LevelForm form, GameField field, int x, int y, int player_number, PlayerKeys keys, List<Enemy> enemies)
        {
            xPlayer = x;
            yPlayer = y;
            Field = field;
            Form = form;
            this.enemies = enemies;

            playerPicture = new PictureBox();

            SetPlayer(x, y, player_number);

            MoveTimer = new Timer();
            MoveTimer.Interval = 250;
            MoveTimer.Tick += new EventHandler(MoveTimer_Tick);
            PlayerCnt++;
            Alive = true;
            playerKeys = keys;
        }

        public void CheckIfHit(Tuple<int, int> coordinates)
        {
            (int x, int y) = coordinates;
            if (xPlayer == x && yPlayer == y) LoseLife();
        }

        public void CreateLives(int player)
        {
            for (int x = 0; x < MaxLives; x++)
            {
                LifeImage[x] = new PictureBox();
                LifeImage[x].Name = "Life" + x.ToString();
                LifeImage[x].SizeMode = PictureBoxSizeMode.AutoSize;
                LifeImage[x].Location = new Point(x * 22 + 15 + 100 * player, 10);
                LifeImage[x].Image = Properties.Resources.Life;
                Form.Controls.Add(LifeImage[x]);
                LifeImage[x].BringToFront();
            }
            SetLives();
        }

        public void CreatePlayerScore()
        {
            // Create Score label
            Score = 0;
            ScoreText = new Label();
            ScoreText.ForeColor = Color.White;
            ScoreText.Font = new Font("Folio XBd BT", 14);
            ScoreText.Top = 10;
            ScoreText.Left = Form.Width / 2 - 50;
            ScoreText.Height = 20;
            ScoreText.Width = 100;
            Form.Controls.Add(ScoreText);
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
                SetLives();
                Move();
                Alive = false;
                PlayerCnt--;
                if (PlayerCnt > 0) playerPicture.Hide();
            }
            else if (Lives > 0)
            {
                SetLives();
            }

            if(PlayerCnt == 0)
            {
                Form.youDiedScreen();               
                Form gameOver = new GameOver();
                Form.Hide();
                MoveTimer.Dispose();
                ScoreText.Dispose();
                gameOver.Closed += (s, args) => { Form.Close(); Form.Dispose(); };
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

        public static void UpdateScore(int amount = 1)
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
            playerPicture.Location = new Point(y * Field.ElementSize + Field.PictureBox.Location.X, x * Field.ElementSize + Field.PictureBox.Location.Y);
            Bitmap Player_transparent;
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
                default:
                    Player_transparent = new Bitmap(Properties.Resources.Player4);
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

        public static event Action<Player> PlayerMoved;

        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            String key = e.KeyCode.ToString();

            if (key == playerKeys.Left.ToUpper())
            {
                if (!goleft)
                {
                    goleft = true;
                    Move();
                }
            }
            if (key == playerKeys.Right.ToUpper())
            {
                if (!goright)
                {
                    goright = true;
                    Move();
                }
            }
            if (key == playerKeys.Up.ToUpper())
            {
                if (!goup)
                {
                    goup = true;
                    Move();
                }
            }
            if (key == playerKeys.Down.ToUpper())
            {
                if (!godown)
                {
                    godown = true;
                    Move();
                }
            }
            if (key == playerKeys.Bomb.ToUpper()) //Pusti bombu na tipku B
            {
                Bomb bomb = new Bomb(Form, Field, Brick, XPlayer, YPlayer);
                bomb.PlantBomb();
                playerPicture.BringToFront();
            }
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            //keyUp = true;
            String key = e.KeyCode.ToString();

            if (key == playerKeys.Left.ToUpper())
            {
                goleft = false;
                MoveStop();
            }
            if (key == playerKeys.Right.ToUpper())
            {
                goright = false;
                MoveStop();
            }
            if (key == playerKeys.Up.ToUpper())
            {
                goup = false;
                MoveStop();
            }
            if (key == playerKeys.Down.ToUpper())
            {
                godown = false;
                MoveStop();
            }
        }
    }
}
