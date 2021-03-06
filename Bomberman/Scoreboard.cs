using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bomberman
{
    public partial class ScoreboardForm : Form
    {
        Menu menu;
        public ScoreboardForm(Menu tempMenu)
        {
            InitializeComponent();
            menu = tempMenu;
            setComponents();
        }

        private void setComponents()
        {
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
            backButton.Location = new Point(Width - backButton.Width * 11 / 8, 12);
            int maxHeight;
            //Računamo visinu da dropdown menu ne bude preko tablice
            if (gameTypeBox.Height * 3 > levelBox.Height * 5)
            {
                maxHeight = gameTypeBox.Height * 3;
            }
            else
            {
                maxHeight = levelBox.Height * 5;
            }
            if (grid.Columns.Count < 2)
            {
                grid.Columns.Add("Username", "USERNAME");
                grid.Columns.Add("Score", "SCORE");
                grid.Width = 435;
            }
            grid.Location = new Point(Width / 2 - 434/2, Height / 3);
            gameTypeBox.Location = new Point(Width / 2 - gameTypeBox.Width / 2 - 50, Height / 3 - maxHeight);
            levelBox.Location = new Point(Width / 2  + 50, Height / 3 - maxHeight);
            gameTypeBox.SelectedIndex = 0;
            drawTable();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void drawTable()
        {
            int gameType = gameTypeBox.SelectedIndex +1;
            int level = levelBox.SelectedIndex +1;
            //Spajanje na SQLite bazu
            string relativePath = @"Database.sqlite";
            var parentDirectory = Path.GetDirectoryName(Application.StartupPath);
            string absolutePath = Path.Combine(parentDirectory, relativePath);
            var connection = new SQLiteConnection("URI=file:" + absolutePath);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "SELECT name, score FROM tablica WHERE type = @type AND level = @level ORDER BY score DESC LIMIT 10";
            command.Parameters.AddWithValue("type", gameType);
            command.Parameters.AddWithValue("level", level);
            command.Prepare();
            var podaci = command.ExecuteReader();
            grid.Width = 435;
            if (grid.Columns.Count < 2)
            {
                grid.Columns.Add("Username", "USERNAME");
                grid.Columns.Add("Score", "SCORE");
                grid.Columns[0].Width = 350;
                grid.Columns[1].Width = 435 - grid.Columns[0].Width;
            }
            grid.Rows.Clear();
            grid.Height = grid.ColumnHeadersHeight;
            //Upisujemo podatke i računamo visinu tablice dinamički
            while (podaci.Read())
            {
                grid.Rows.Add(podaci.GetString(0), podaci.GetInt32(1));
                grid.Height += 42;
            }         
            grid.Refresh();
        }

        private void updateGameTypeForTable(object sender, EventArgs e) //Promijena tipa igre
        {
            if (gameTypeBox.SelectedIndex == 0) //Campaing mode nema izbor levela
            {
                levelBox.Enabled = false;
                levelBox.SelectedIndex = -1;
            }
            else
            {
                levelBox.Enabled = true;
                if (levelBox.SelectedIndex == 0)
                {
                    drawTable();
                }
                else
                {
                    levelBox.SelectedIndex = 0;
                }
            }
        }

        private void changeTable(object sender, EventArgs e) //Promijena levela za koji se prikazuje tablica
        {
            drawTable();
        }
    }
}
