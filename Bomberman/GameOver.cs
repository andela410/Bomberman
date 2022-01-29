using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Bomberman
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
            setComponents();            
        }

        private void setComponents()
        {
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
            save.Location = new Point(Width / 2 - save.Width / 2, Height * 2 / 3);
            gameOverLabel.Location = new Point(Width / 2 - gameOverLabel.Width / 2, Height / 4);
            nameTextBox.Location = new Point(Width / 2 - gameOverLabel.Width / 2, Height / 2);
            scoreLabel.Location = new Point(Width / 2 - gameOverLabel.Width / 2 + nameTextBox.Width + Width / 30, Height / 2);
            scoreNumber.Location = new Point(Width / 2 - gameOverLabel.Width / 2 + nameTextBox.Width + Width / 30 + scoreLabel.Width, Height / 2);
            //scoreNumber.Text = ToString(NEKI SCORE);
        }
        private void save_Click(object sender, EventArgs e)
        {
            //spremaju se podaci u tablicu i vraća na LevelMenu
            string name = nameTextBox.Text;           
            int score = 333;
            int gameType = 7;
            int level = 6;
            
            string relativePath = @"Database.sqlite";
            var parentDirectory = Path.GetDirectoryName(Application.StartupPath);
            string absolutePath = Path.Combine(parentDirectory, relativePath);
            var connection = new SQLiteConnection("URI=file:" + absolutePath);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "INSERT INTO tablica (type, level, name, score) VALUES (@type, @level, @name, @score)";
            command.Parameters.AddWithValue("type", gameType);
            command.Parameters.AddWithValue("level", level);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("score", score);
            command.Prepare();
            command.ExecuteNonQuery();

            Close();
        }

    }
}
