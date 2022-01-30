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


        public Enemy(LevelForm form, GameField field, int x, int y, int type, string direction)
        {
            enemyCnt++;
            xEnemy = x;
            yEnemy = y;
            Field = field;
            Form = form;
            Direction = direction;
            EnemyType = type;

            EnemyTimer = new Timer();
            if (type == 1)
                EnemyTimer.Interval = 500;
            else if (type == 2)
                EnemyTimer.Interval = 400;
            else if (type == 3)
                EnemyTimer.Interval = 250;
            
            EnemyTimer.Tick += new EventHandler(EnemyTimer_Tick);
            EnemyTimer.Start();

            enemyPicture = new PictureBox();

            SetEnemy(x, y, type);
            //Move();
        }
        public void CheckIfPlayerHit(Player player)
        {
            if (player.XPlayer == XEnemy && player.YPlayer == YEnemy)
                player.LoseLife();

        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            if (Direction == "left")
            {
                if (Field.Field[xEnemy, yEnemy - 1] == ' ')
                {
                    yEnemy--;
                }
                else if (Field.Field[xEnemy, yEnemy + 1] == ' ')
                {
                    yEnemy++;
                    Direction = "right";
                }
            }
            else if (Direction == "right")
            {
                if (Field.Field[xEnemy, yEnemy + 1] == ' ')
                {
                    yEnemy++;
                }
                else if (Field.Field[xEnemy, yEnemy - 1] == ' ')
                {
                    yEnemy--;
                    Direction = "left";
                }
            }
            else if(Direction == "down")
            {
                if (Field.Field[xEnemy + 1, yEnemy] == ' ')
                { 
                    xEnemy++;
                }
                else if(Field.Field[xEnemy - 1, yEnemy] == ' ')
                {
                    xEnemy--;
                    Direction = "up";
                }
            }
            else if(Direction == "up")
            {
                if (Field.Field[xEnemy - 1, yEnemy] == ' ')
                {
                    xEnemy--;
                }
                else if (Field.Field[xEnemy + 1, yEnemy] == ' ')
                {
                    xEnemy++;
                    Direction = "down";
                }
            }

            enemyPicture.Location = new Point(yEnemy * Field.ElementSize + Field.PictureBox.Location.X, xEnemy * Field.ElementSize + Field.PictureBox.Location.Y);
                Form.Controls.Add(enemyPicture);

                enemyPicture.BringToFront();

            cnt = rand.Next(4);

            if(cnt % 3 == 0 && (Direction == "right" || Direction == "left"))
            {
                if (Field.Field[xEnemy - 1, yEnemy] == ' ')
                    Direction = "up";
                else if (Field.Field[xEnemy + 1, yEnemy] == ' ')
                    Direction = "down";
             }
            else if (cnt % 3 == 0 && (Direction == "up" || Direction == "down"))
            {
                if (Field.Field[xEnemy, yEnemy - 1] == ' ')
                    Direction = "left";
                else if(Field.Field[xEnemy, yEnemy + 1] == ' ')
                    Direction="right";
            }
            EnemyMoved?.Invoke(new Tuple<int, int>(xEnemy, yEnemy));
        }

        public static event Action<Tuple<int, int>> EnemyMoved;

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

        internal void CheckIfHit(Tuple<int, int> coordinates)
        {
            (int x, int y) = coordinates;
            if (x == XEnemy && y == YEnemy) Die();
        }

        public void Die()
        {
            Form.UpdateTotalScore(100 * enemyType);
            Field.ShowScore(100 * enemyType, xEnemy, yEnemy);
            CleanUp();
            if (--enemyCnt == 0) // Ako unistimo sve neprijatelje pokazu nam se vrata (nije jos dokraja implementirano)
            {
                Field.EnableLevelPass();
            }
        }

        public void CleanUp()
        {
            xEnemy = -1;
            yEnemy = -1;
            EnemyTimer.Stop();
            enemyPicture.Dispose();
            EnemyTimer.Dispose();
        }
    }
}
