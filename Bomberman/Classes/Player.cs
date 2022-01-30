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
        private bool Alive;
        private bool Stopped;
        private bool GoLeft;
        private bool GoRight;
        private bool GoUp;
        private bool GoDown;
        GameField Field;
        LevelForm Form;
        PictureBox playerPicture;
        Timer MoveTimer;
        public int Lives = 3;
        public int MaxLevel = 1;
        public static Label ScoreText = new Label();
        public PictureBox[] LifeImage = new PictureBox[MaxLives];

        public Brick Brick { get; set; }

        public int XPlayer { get; private set; }

        public int YPlayer { get; private set; }

        public PlayerKeys PlayerKeys { get; set; }

        // Konstruktor
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

        // Provjera je li nešto došlo na mjesto igrača, eksplozija bombe ili neprijatelj
        // Metoda služi da se pretplati na događaje pomaka neprijatelja i eksplozije bombe
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

        // Postavlja slike srca za svakog igrača
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
            playerPicture.Location = new Point(YPlayer * Field.ElementSize + Field.PictureBox.Location.X, XPlayer * Field.ElementSize + Field.PictureBox.Location.Y);
            Form.Controls.Add(playerPicture);
            
            playerPicture.BringToFront();
        }

        async public void LoseLife()
        {
            // Ako je broj života pozitivan, oduzmi jedan
            if (Lives > 0) Lives--;
            else return;

            Form.StopAllEnemies();
            Form.StopPlayers();

            for (int i = 1; i < 5; ++i)
            {
                // Slika igraca blinka kad izgubi zivot
                playerPicture.Visible = false;
                await Task.Delay(i * 100);
                playerPicture.Visible = true;
                await Task.Delay(i * 100);
            }

            // Ukloni sve aktivne bombe i njihove eksplozije prije nastavka
            Bomb.RemoveActiveBombs();

            // Ako je broj života jednak 0, taj igrač je mrtav
            if (Lives == 0)
            {
                SetLives();
                Move();
                Alive = false;
                Form.PlayerCnt--;
                if (Form.PlayerCnt > 0) playerPicture.Hide();
            }

            // Inače prikaži ostale živote
            else if (Lives > 0)
                SetLives();
            
            // Ako su svi igrači mrtvi, pojavljuje se prikladna poruka
            if (Form.PlayerCnt == 0)
            {
                MoveTimer.Dispose();
                Form.GameOver();
            }

            // Ako se izgubi život, igrač ide na početnu poziciju
            ResetPlayerPosition();
            // Pokreni igrace
            Form.StartPlayers();
            // Pokreni enemies
            Form.StartAllEnemies();
        }

        // "Resetira" varijable
        public void CleanUp()
        {
            MoveTimer.Dispose();
            XPlayer = -100;
            YPlayer = -100;
            Alive = false;
        }

        // Postavljanje slike igrača na zadanu poziciju, poziva se u konstruktoru
        private void SetPlayer(int x, int y, int player_number)
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
            if (!Alive || Stopped) return;
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

            // Ako se igrac pomaknuo na eksploziju, oduzmi zivot
            if (Field.Field[XPlayer, YPlayer] == 'x') LoseLife();

            PlayerMoved?.Invoke(this);
        }

        public void MoveStop()
        {
            MoveTimer.Enabled = false;
        }

        // Event na koji se enemy pretplate tako da se moze izgubiti život kada se igrač kreće
        // i pređe preko neprijatelja
        public static event Action<Player> PlayerMoved;

        // Metoda koja reagira kada pritisnemo tipku ako je igrač živ
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

        // Metoda koja reagira kada otpustimo tipku ako je igrač živ
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

        // Zaustavi kretanje igraca kad se izgubi zivot
        public void StopTimer()
        {
            Stopped = true;
        }

        // Nastavi kretanje zivog igraca
        public void StartTimer()
        {
            if (Alive)
            {
                Stopped = false;
            }
        }
    }
}
