using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace Bomberman.Classes
{
    //klasa koja predstavlja igrača
    public class Player
    {
        private const int MaxLives = 10;
        public int Lives = 3;
        public int MaxLevel = 1;
        public static Label ScoreText = new Label();
        public PictureBox[] LifeImage = new PictureBox[MaxLives];
        GameField Field;
        LevelForm Form;
        PictureBox playerPicture;
        Timer MoveTimer;
        bool Alive;

        public Brick Brick 
        {
            get; set;
        }

        public int XPlayer { get; private set; }

        public int YPlayer { get; private set; }

        public bool GoLeft
        {
            get; set;
        }

        public bool GoRight
        {
            get; set;
        }

        public bool GoUp
        {
            get; set;
        }

        public bool GoDown
        {
            get; set;
        }

        public PlayerKeys PlayerKeys { get; set; }

        //konstruktor
        public Player(LevelForm form, GameField field, int x, int y, int player_number, PlayerKeys keys)
        {
            XPlayer = x;
            YPlayer = y;
            Field = field;
            Form = form;

            playerPicture = new PictureBox();

            SetPlayer(x, y, player_number);

            MoveTimer = new Timer 
            {
                Interval = 250
            };
            MoveTimer.Tick += new EventHandler(MoveTimer_Tick);
            Alive = true;
            PlayerKeys = keys;
        }

        //provjera je li nešto došlo na mjesto igrača
        public void CheckIfHit(Tuple<int, int> coordinates)
        {
            (int x, int y) = coordinates;
            if (XPlayer == x && YPlayer == y)
                LoseLife();
        }

        public void CreateLives(int player)
        {
            for (int x = 0; x < MaxLives; x++)
            {
                LifeImage[x] = new PictureBox
                {
                    Name = "Life" + x.ToString(),
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Location = new Point(x * 22 + 15 + 100 * player, 10),
                    Image = Properties.Resources.Life
                };
                Form.Controls.Add(LifeImage[x]);
                LifeImage[x].BringToFront();
            }
            SetLives();
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

        private void ResetPlayerPosition()
        {
            XPlayer = 1;
            YPlayer = 1;
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
                Form.PlayerCnt--;
                if (Form.PlayerCnt > 0) playerPicture.Hide();
            }
            else if (Lives > 0)
            {
                SetLives();
            }

            if(Form.PlayerCnt == 0)
            {
                MoveTimer.Dispose();
                Form.GameOver();
            }
            ResetPlayerPosition();
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

        //postavljanje slike igrača na zadanu poziciju
        private void SetPlayer(int x, int y, int player_number) //pozovi u konstruktoru
        {

            //PictureBox e = new PictureBox();
            // e.Name = "Fire" + x.ToString() + y.ToString();

            playerPicture.Name = "Player" + XPlayer.ToString() + YPlayer.ToString();
            playerPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            playerPicture.Location = new Point(y * Field.ElementSize + Field.PictureBox.Location.X, x * Field.ElementSize + Field.PictureBox.Location.Y);
            Bitmap Player_transparent;
            switch (player_number) //odabir slike igrača ovisno o odabiru korisnika
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
            if (GoLeft == true)
            {
                if (Field.Field[XPlayer, YPlayer - 1] == ' ' || Field.Field[XPlayer, YPlayer - 1] == 'd' || Field.Field[XPlayer, YPlayer - 1] == 'x')
                {
                    YPlayer--;
                }
            }
            else if (GoRight == true)
            {
                if (Field.Field[XPlayer, YPlayer + 1] == ' ' || Field.Field[XPlayer, YPlayer + 1] == 'd' || Field.Field[XPlayer, YPlayer + 1] == 'x')
                {
                    YPlayer++;
                }
            }
            else if (GoDown == true)
            {
                if (Field.Field[XPlayer + 1, YPlayer] == ' ' || Field.Field[XPlayer + 1, YPlayer] == 'd' || Field.Field[XPlayer + 1, YPlayer] == 'x')
                {
                    XPlayer++;
                }
            }
            else if (GoUp == true)
            {
                if (Field.Field[XPlayer - 1, YPlayer] == ' ' || Field.Field[XPlayer - 1, YPlayer] == 'd' || Field.Field[XPlayer - 1, YPlayer] == 'x')
                {
                    XPlayer--;
                }
            }

            playerPicture.Location = new Point(YPlayer * Field.ElementSize + Field.PictureBox.Location.X, XPlayer * Field.ElementSize + Field.PictureBox.Location.Y);
            Form.Controls.Add(playerPicture);

            playerPicture.BringToFront();

            // ako se igrac pomaknuo na eksploziju, oduzmi zivot
            if (Field.Field[XPlayer, YPlayer] == 'x') LoseLife();

            PlayerMoved?.Invoke(this);
        }

        public void MoveStop()
        {
            MoveTimer.Enabled = false;
        }

        public static event Action<Player> PlayerMoved;

        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (!Alive) return;
            String key = e.KeyCode.ToString();

            if (key == PlayerKeys.Left.ToUpper())
            {
                if (!GoLeft)
                {
                    GoLeft = true;
                    Move();
                }
            }
            if (key == PlayerKeys.Right.ToUpper())
            {
                if (!GoRight)
                {
                    GoRight = true;
                    Move();
                }
            }
            if (key == PlayerKeys.Up.ToUpper())
            {
                if (!GoUp)
                {
                    GoUp = true;
                    Move();
                }
            }
            if (key == PlayerKeys.Down.ToUpper())
            {
                if (!GoDown)
                {
                    GoDown = true;
                    Move();
                }
            }
            if (key == PlayerKeys.Bomb.ToUpper()) //Pusti bombu na tipku B
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

            if (key == PlayerKeys.Left.ToUpper())
            {
                GoLeft = false;
                MoveStop();
            }
            if (key == PlayerKeys.Right.ToUpper())
            {
                GoRight = false;
                MoveStop();
            }
            if (key == PlayerKeys.Up.ToUpper())
            {
                GoUp = false;
                MoveStop();
            }
            if (key == PlayerKeys.Down.ToUpper())
            {
                GoDown = false;
                MoveStop();
            }
        }
    }
}
