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
    //klasa koja predstavlja neprijatelje 
    public class Enemy
    {
        private int xEnemy, yEnemy;
        private int enemyType;
        public static int enemyCnt = 0;
        GameField Field;
        LevelForm Form;
        PictureBox enemyPicture;
        string Direction;
        private Timer EnemyTimer;
        int cnt = 0;
        Random rand = new Random();
        //imamo više neprijatelja različitih tipova koji se mogu micati u svim smjerovima nasumično
        public int XEnemy
        {
            get { return xEnemy; }
        }

        public int YEnemy
        {
            get { return yEnemy; }
        }
        public int EnemyType
        {
            get { return enemyType; }
            set { enemyType = value; }
        }

        public bool Alive
        {
            get; set;
        }

        //konstruktor za neprijatelja
        public Enemy(LevelForm form, GameField field, int x, int y, int type, string direction)
        {
            enemyCnt++;
            xEnemy = x;
            yEnemy = y;
            Field = field;
            Form = form;
            Direction = direction;
            EnemyType = type;
            Alive = true;

            EnemyTimer = new Timer();
            if (type == 1)
                EnemyTimer.Interval = 500;
            else if (type == 2)
                EnemyTimer.Interval = 400;
            else if (type == 3)
                EnemyTimer.Interval = 250;
            
            EnemyTimer.Tick += new EventHandler(EnemyTimer_Tick);
            EnemyTimer.Start();
            //zelimo pozivati metodu EnemyTimer_Tick periodički (svakih 500/400/250 ms), zato postavimo vremenske
            //intervale ovisno o tipu neprijatelja
            //upravljamo na taj način njihovim kretanjem i mijenjanjem smjera
            enemyPicture = new PictureBox();

            SetEnemy(x, y, type);
            //Move();
        }

        //provjeravamo je li igrač na poziciji neprijatelja
        //u slučaju da je, igrač gubi život
        public void CheckIfPlayerHit(Player player)
        {
            if (player.XPlayer == XEnemy && player.YPlayer == YEnemy)
                player.LoseLife();

        }

        //upravljamo smjerom kretanja
        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            if (Direction == "left")
            {
                if (Field.Field[xEnemy, yEnemy - 1] == ' ' || Field.Field[xEnemy, yEnemy - 1] == 'x')
                {
                    yEnemy--;
                }
                else if (Field.Field[xEnemy, yEnemy + 1] == ' ' || Field.Field[xEnemy, yEnemy + 1] == 'x')
                {
                    yEnemy++;
                    Direction = "right";
                }
            }
            else if (Direction == "right")
            {
                if (Field.Field[xEnemy, yEnemy + 1] == ' ' || Field.Field[xEnemy, yEnemy + 1] == 'x')
                {
                    yEnemy++;
                }
                else if (Field.Field[xEnemy, yEnemy - 1] == ' ' || Field.Field[xEnemy, yEnemy - 1] == 'x')
                {
                    yEnemy--;
                    Direction = "left";
                }
            }
            else if(Direction == "down")
            {
                if (Field.Field[xEnemy + 1, yEnemy] == ' ' || Field.Field[xEnemy + 1, yEnemy] == 'x')
                { 
                    xEnemy++;
                }
                else if(Field.Field[xEnemy - 1, yEnemy] == ' ' || Field.Field[xEnemy - 1, yEnemy] == 'x')
                {
                    xEnemy--;
                    Direction = "up";
                }
            }
            else if(Direction == "up")
            {
                if (Field.Field[xEnemy - 1, yEnemy] == ' ' || Field.Field[xEnemy - 1, yEnemy] == 'x')
                {
                    xEnemy--;
                }
                else if (Field.Field[xEnemy + 1, yEnemy] == ' ' || Field.Field[xEnemy + 1, yEnemy] == 'x')
                {
                    xEnemy++;
                    Direction = "down";
                }
            }
            //omogućujemo vidljivost sličice neprijatelja na zadanoj lokaciji
            enemyPicture.Location = new Point(yEnemy * Field.ElementSize + Field.PictureBox.Location.X, xEnemy * Field.ElementSize + Field.PictureBox.Location.Y);
                Form.Controls.Add(enemyPicture);

                enemyPicture.BringToFront();

            cnt = rand.Next(4); //generira proizvoljan broj manji od 4
            //ovisno o generiranom broju, mijenjamo smjer kretanja
            if(cnt % 3 == 0 && (Direction == "right" || Direction == "left"))
            {
                if (Field.Field[xEnemy - 1, yEnemy] == ' ' || Field.Field[xEnemy - 1, yEnemy] == 'x')
                    Direction = "up";
                else if (Field.Field[xEnemy + 1, yEnemy] == ' ' || Field.Field[xEnemy + 1, yEnemy] == 'x')
                    Direction = "down";
             }
            else if (cnt % 3 == 0 && (Direction == "up" || Direction == "down"))
            {
                if (Field.Field[xEnemy, yEnemy - 1] == ' ' || Field.Field[xEnemy, yEnemy - 1] == 'x')
                    Direction = "left";
                else if(Field.Field[xEnemy, yEnemy + 1] == ' ' || Field.Field[xEnemy, yEnemy + 1] == 'x')
                    Direction="right";
            }

            // Ako se Enemy pomaknuo na eksploziju, unisti ga
            if (Field.Field[xEnemy, yEnemy] == 'x') Die();

            EnemyMoved?.Invoke(new Tuple<int, int>(xEnemy, yEnemy));
        }

        public static event Action<Tuple<int, int>> EnemyMoved;

        //postavljanje neprijatelja na poziciju
        private void SetEnemy(int x, int y, int type)
        {
            enemyPicture.Name = "Enemy" + xEnemy.ToString() + yEnemy.ToString();
            enemyPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyPicture.Location = new Point(y * Field.ElementSize + Field.PictureBox.Location.X, x * Field.ElementSize + Field.PictureBox.Location.Y);

            Bitmap Enemy_transparent = new Bitmap(Properties.Resources.Enemy);

            if(type == 1)
                Enemy_transparent = new Bitmap(Properties.Resources.Enemy);
            else if(type == 2)
                Enemy_transparent = new Bitmap(Properties.Resources.Enemy2);
            else if(type == 3)
                Enemy_transparent = new Bitmap(Properties.Resources.Enemy3);


            Enemy_transparent.MakeTransparent(Color.White);
            enemyPicture.Image = Enemy_transparent;
            Form.Controls.Add(enemyPicture);

            enemyPicture.BringToFront();
        }

        //provjera je li nesto na poziciji neprijatelja
        internal void CheckIfHit(Tuple<int, int> coordinates)
        {
            (int x, int y) = coordinates;
            if (x == XEnemy && y == YEnemy) Die();
        }


        //uništimo neprijatelja
        public void Die()
        {
            Alive = false;
            Form.UpdateTotalScore(100 * enemyType);
            Field.ShowScore(100 * enemyType, xEnemy, yEnemy);
            CleanUp();
            if (--enemyCnt == 0) // Ako unistimo sve neprijatelje pokazu nam se vrata (nije jos dokraja implementirano)
            {
                Field.EnableLevelPass();
            }
        }

        //neprijatelj postaje nevidljiv i nalazi se na poziciji (-1,-1)
        public void CleanUp()
        {
            xEnemy = -1;
            yEnemy = -1;
            EnemyTimer.Stop();
            enemyPicture.Dispose();
            EnemyTimer.Dispose();
        }

        public void StopTimer()
        {
            EnemyTimer.Stop();
        }

        public void StartTimer()
        {
            EnemyTimer.Start();
        }
    }
}
