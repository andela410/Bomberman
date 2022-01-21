﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace Bomberman.Classes
{
    public class Enemy
    {
        private int xEnemy, yEnemy;
        GameField Field;
        Form Form;
        PictureBox enemyPicture;
        string Direction;
        private Timer EnemyTimer;
        int cnt = 0;
        Player player;

        public int XEnemy
        {
            get { return xEnemy; }
        }

        public int YEnemy
        {
            get { return yEnemy; }
        }

        public Enemy(Form form, GameField field, int x, int y, string direction, Player player_construct)
        {
            xEnemy = x;
            yEnemy = y;
            Field = field;
            Form = form;
            Direction = direction;
            player = player_construct;

            EnemyTimer = new Timer();
            EnemyTimer.Interval = 500;
            EnemyTimer.Tick += new EventHandler(EnemyTimer_Tick);
            EnemyTimer.Start();

            enemyPicture = new PictureBox();

            SetEnemy(x, y);
            //Move();
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
 
            if (Direction == "left")
            {
                if (Field.Field[xEnemy, yEnemy - 1] != 'w' && Field.Field[xEnemy, yEnemy - 1] != 'b' && Field.Field[xEnemy, yEnemy - 1] != 'h')
                {
                    yEnemy--;
                }
                else if (Field.Field[xEnemy, yEnemy + 1] != 'w' && Field.Field[xEnemy, yEnemy + 1] != 'b' && Field.Field[xEnemy, yEnemy + 1] != 'h')
                {
                    yEnemy++;
                    Direction = "right";
                }
            }
            else if (Direction == "right")
            {
                if (Field.Field[xEnemy, yEnemy + 1] != 'w' && Field.Field[xEnemy, yEnemy + 1] != 'b' && Field.Field[xEnemy, yEnemy + 1] != 'h')
                {
                    yEnemy++;
                }
                else if (Field.Field[xEnemy, yEnemy - 1] != 'w' && Field.Field[xEnemy, yEnemy - 1] != 'b' && Field.Field[xEnemy, yEnemy - 1] != 'h')
                {
                    yEnemy--;
                    Direction = "left";
                }
            }
            else if(Direction == "down")
            {
                if (Field.Field[xEnemy + 1, yEnemy] != 'w' && Field.Field[xEnemy + 1, yEnemy] != 'b' && Field.Field[xEnemy + 1, yEnemy] != 'h')
                { 
                    xEnemy++;
                }
                else if(Field.Field[xEnemy - 1, yEnemy] != 'w' && Field.Field[xEnemy - 1, yEnemy] != 'b' && Field.Field[xEnemy - 1, yEnemy] != 'h')
                {
                    xEnemy--;
                    Direction = "up";
                }
            }
            else if(Direction == "up")
            {
                if (Field.Field[xEnemy - 1, yEnemy] != 'w' && Field.Field[xEnemy - 1, yEnemy] != 'b' && Field.Field[xEnemy - 1, yEnemy] != 'h')
                {
                    xEnemy--;
                }
                else if (Field.Field[xEnemy + 1, yEnemy] != 'w' && Field.Field[xEnemy + 1, yEnemy] != 'b' && Field.Field[xEnemy + 1, yEnemy] != 'h')
                {
                    xEnemy++;
                    Direction = "down";
                }

            }

            enemyPicture.Location = new Point(yEnemy * Field.ElementSize + Field.PictureBox.Location.X, xEnemy * Field.ElementSize + Field.PictureBox.Location.Y);
                Form.Controls.Add(enemyPicture);

                enemyPicture.BringToFront();

            cnt++;//probat s random

            if(cnt % 3 == 0 && (Direction == "right" || Direction == "left"))
            {
                if (Field.Field[xEnemy - 1, yEnemy] != 'w' && Field.Field[xEnemy - 1, yEnemy] != 'b' && Field.Field[xEnemy - 1, yEnemy] != 'h')
                    Direction = "up";
                else if (Field.Field[xEnemy + 1, yEnemy] != 'w' && Field.Field[xEnemy + 1, yEnemy] != 'b' && Field.Field[xEnemy + 1, yEnemy] != 'h')
                    Direction = "down";
             }
            else if (cnt % 3 == 0 && (Direction == "up" || Direction == "down"))
            {
                if (Field.Field[xEnemy, yEnemy - 1] != 'w' && Field.Field[xEnemy, yEnemy - 1] != 'b' && Field.Field[xEnemy, yEnemy - 1] != 'h')
                    Direction = "left";
                else if(Field.Field[xEnemy, yEnemy + 1] != 'w' && Field.Field[xEnemy, yEnemy + 1] != 'b' && Field.Field[xEnemy, yEnemy + 1] != 'h')
                    Direction="right";
            }
            if (XEnemy == player.XPlayer && YEnemy == player.YPlayer) player.LoseLife();
        }

            private void SetEnemy(int x, int y) //pozovi u konstruktoru
        {
            enemyPicture.Name = "Enemy" + xEnemy.ToString() + yEnemy.ToString();
            enemyPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyPicture.Location = new Point(x * Field.ElementSize + Field.PictureBox.Location.X, y * Field.ElementSize + Field.PictureBox.Location.Y);
            Bitmap Enemy_transparent = new Bitmap(Properties.Resources.Enemy);
            

            Enemy_transparent.MakeTransparent(Color.White);
            enemyPicture.Image = Enemy_transparent;
            Form.Controls.Add(enemyPicture);

            enemyPicture.BringToFront();
        }

        public void Die()
        {
            xEnemy = -1;
            yEnemy = -1;
            EnemyTimer.Stop();
            enemyPicture.Dispose();
            
        }

        

    }
}
