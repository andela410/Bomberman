using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bomberman.Classes
{
    // Klasa koja predstavlja bombe koje se postavljaju u polju
    public class Bomb
    {
        PictureBox bomb, fire;
        private Timer BombTimer, FireTimer;
        private int X, Y;
        GameField Field;
        LevelForm Form;
        Brick Brick;
        int BombStrength = 2;
        List<PictureBox> Explosion = new List<PictureBox>();
        List<Tuple<int, int>> LogicalExplosion = new List<Tuple<int, int>>();
        static List<Tuple<Bomb, int, int>> BombPositions = new List<Tuple<Bomb, int, int>>();

        // Konstruktor 
        public Bomb(LevelForm form, GameField field, Brick brick, int x, int y)
        {
            X = x;
            Y = y;
            Field = field;
            Form = form;
            Brick = brick;

            // inicijaliziraj timer za bombu
            BombTimer = new Timer();
            BombTimer.Interval = 3000;
            BombTimer.Tick += new EventHandler(BombTimer_Tick);

            // inicijaliziraj timer za eksploziju
            FireTimer = new Timer();
            FireTimer.Interval = 1000;
            FireTimer.Tick += new EventHandler(FireTimer_Tick);

            bomb = new PictureBox();
            fire = new PictureBox();
        }

        // Metoda za logičko i slikovno prikazivanje bombe
        public void PlantBomb()
        {
            bomb.Name = "Bomb" + X.ToString() + Y.ToString();
            bomb.SizeMode = PictureBoxSizeMode.AutoSize;
            bomb.Location = new Point(Y * Field.ElementSize + Field.PictureBox.Location.X + 2, X * Field.ElementSize + Field.PictureBox.Location.Y + 2);
            bomb.Image = Properties.Resources.Bomb;
            Form.Controls.Add(bomb);
            bomb.BringToFront();

            BombPositions.Add(new Tuple<Bomb, int, int>(this, X, Y));

            PrepareExplosion();
            Field.UpdateFieldToBomb(X, Y);
            BombTimer.Enabled = true;
        }

        // Metoda za logičko i slikovno prikazivanje eksplozije
        private void SetExplosion(int x, int y)
        {
            if (x > 0 && y > 0 && Field.Field[x, y] != 'w')
            {
                PictureBox e = new PictureBox();
                e.Name = "Fire" + x.ToString() + y.ToString();
                e.SizeMode = PictureBoxSizeMode.AutoSize;
                e.Location = new Point(y * Field.ElementSize + Field.PictureBox.Location.X, x * Field.ElementSize + Field.PictureBox.Location.Y);
                e.Image = Properties.Resources.Fire1;
                Form.Controls.Add(e);

                Explosion.Add(e);
                LogicalExplosion.Add(new Tuple<int, int>(x, y));
            }
        }

        // Event na koji se pretplate Enemy objekti i Player objekti 
        public static event Action<Tuple<int, int>> BombExploadedEvent;

        private void BombTimer_Tick(object sender, EventArgs e)
        {
            bomb.Visible = false;
            BombTimer.Enabled = false;

            // eksplozija
            for (int i = 0; i < Explosion.Count(); ++i)
            {
                (int x, int y) = LogicalExplosion[i];

                Explosion[i].BringToFront();
                BombExploadedEvent?.Invoke(new Tuple<int, int>(x, y));
                Field.UpdateFieldToExplosion(x, y);

                // Prodji kroz sve postavljenje bombe i vidi preklapa li se pozicija
                // sa eksplozijom bombe koja je eksplodirala
                foreach (var BombPosition in BombPositions)
                {
                    if (BombPosition.Item1 != this && x == BombPosition.Item2 && y == BombPosition.Item3)
                    {
                        BombPosition.Item1.BombTimer.Interval = 1;
                    }
                }
            }
            FireTimer.Enabled = true;
        }

        private void FireTimer_Tick(object sender, EventArgs e)
        {
            FireTimer.Enabled = false;

            // ugasi eksploziju
            foreach (var ex in Explosion)
            {
                ex.Visible = false;
            }

            // unisti cigle eksplozijom i dodaj playeru score
            foreach((int x, int y) in LogicalExplosion)
            {
                if (Field.Field[x, y] == 'b')
                {
                    if (Brick.DestroyBrickWall(x, y))
                        Form.UpdateTotalScore(100);
                }
                else if(Field.Field[x, y] == 'h')
                {
                    if (Brick.DestroyDoorBrick(x, y))
                        Form.UpdateTotalScore(200);
                }
                else if (Field.Field[x, y] == 'x')
                {
                    Field.UpdateField(x, y);
                }
            }

            Tuple<Bomb, int, int> temp = null;
            foreach (var BombPosition in BombPositions)
            {
                if (BombPosition.Item1 == this)
                {
                    // Ova bomba je eksplodirala, izbaci je iz liste pozicija
                    temp = BombPosition;
                    break;
                }
            }
            if (temp != null)
            {
                BombPositions.Remove(temp);
                Field.UpdateField(temp.Item2, temp.Item3);
            }
        }

        private void PrepareExplosion()
        {
            // Eksplozija na mjestu bombe
            SetExplosion(X, Y);

            // Ekplozija u smjeru prema dolje
            for (int i = 1; i <= BombStrength; ++i)
            {
                // Ako naidjemo na stup, prekini
                if (Field.Field[X + i, Y] == 'w')
                {
                    break;
                }
                // Postavi eksploziju
                SetExplosion(X + i, Y);
                
                // Ako smo raznijeli ciglu, ne idi dalje
                if (Field.Field[X + i, Y] == 'b' || Field.Field[X + i, Y] == 'h')
                {
                    break;
                }
            }

            // Eksplozija u smjeru prema desno
            for (int i = 1; i <= BombStrength; ++i)
            {
                if (Field.Field[X, Y + i] == 'w')
                {
                    break;
                }
                SetExplosion(X, Y + i);
                if (Field.Field[X, Y + i] == 'b' || Field.Field[X, Y + i] == 'h')
                {
                    break;
                }
            }

            // Eksplozija u smjeru prema gore
            for (int i = 1; i <= BombStrength; ++i)
            {
                if (Field.Field[X - i, Y] == 'w')
                {
                    break;
                }
                SetExplosion(X - i, Y);
                if (Field.Field[X - i, Y] == 'b' || Field.Field[X - i, Y] == 'h')
                {
                    break;
                }
            }

            // Eksplozija u smjeru prema lijevo
            for (int i = 1; i <= BombStrength; ++i)
            {
                if (Field.Field[X, Y - i] == 'w')
                {
                    break;
                }
                SetExplosion(X, Y - i);
                if (Field.Field[X, Y - i] == 'b' || Field.Field[X, Y - i] == 'h')
                {
                    break;
                }
            }
        }

        public static void RemoveActiveBombs()
        {
            foreach (var bomb in BombPositions)
            {
                // ugasi bomb & explosion timere
                bomb.Item1.BombTimer.Dispose();
                bomb.Item1.FireTimer.Dispose();

                // Izbrisi 'b' iz polja
                bomb.Item1.Field.UpdateField(bomb.Item2, bomb.Item3);

                // Makni bombu
                bomb.Item1.bomb.Hide();

                // Ugasi eksploziju
                foreach (var ex in bomb.Item1.Explosion)
                {
                    ex.Hide();
                }

                // Izbrisi 'x' iz polja
                foreach (var exPosition in bomb.Item1.LogicalExplosion)
                {
                    bomb.Item1.Field.UpdateField(exPosition.Item1, exPosition.Item2);
                }
            }

            // ocisti listu bombi
            BombPositions.Clear();
        }
    }
}
