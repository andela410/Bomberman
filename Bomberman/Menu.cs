using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Data.SQLite;
using System.IO;

namespace Bomberman
{
    public partial class Menu : Form
    {
        SoundPlayer soundPlayer;
        private bool sviraMuzika;
        Form levelMenu;
        Form settingsForm;
        Form scoreboardForm;
        PlayerKeys p1keys;
        PlayerKeys p2keys;

        public bool SviraMuzika
        {
            get { return sviraMuzika; }
            set { sviraMuzika = value; }
        }

        public Menu()
        {
            InitializeComponent();
            createTable();
            setComponents();           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void setComponents()
        {
            //Dinamički zadajemo pozicije elemenata
            int vert_pomak = (Height - naslov.Height - 5 * campaignButton.Height) / 2;
            naslov.Location = new Point((Width - naslov.Width) / 2, vert_pomak);
            vert_pomak += 25;
            campaignButton.Location = new Point((Width - campaignButton.Width) / 3, vert_pomak + 120);
            singleplayerButton.Location = new Point((Width - campaignButton.Width) / 3, vert_pomak + 250);
            multiplayerButton.Location = new Point((Width - campaignButton.Width) / 3, vert_pomak + 380);

            settingsButton.Location = new Point((Width - settingsButton.Width) * 2 / 3, vert_pomak + 120);
            scoreboardButton.Location = new Point((Width - scoreboardButton.Width) * 2 / 3, vert_pomak + 250);
            exitButton.Location = new Point((Width - exitButton.Width) * 2 / 3, vert_pomak + 380);

            naslov.FlatAppearance.MouseOverBackColor = naslov.BackColor;
            naslov.BackColorChanged += (s, e) => {
                naslov.FlatAppearance.MouseOverBackColor = naslov.BackColor;
            };
            //Pokreće se muzika
            soundPlayer = new SoundPlayer(Properties.Resources.Black_Betty);
            soundPlayer.PlayLooping();
            sviraMuzika = true;
            p1keys = new PlayerKeys("a", "w", "s", "d", "c");
            p2keys = new PlayerKeys("j", "i", "k", "l", "n");
        }

        private void campaignButton_Click(object sender, EventArgs e)
        {
            Hide();
            levelMenu = new LevelMenu(this, 1, p1keys, p2keys);
            levelMenu.Show();
            levelMenu.Closed += (s, args) => { Show(); };
        }

        private void singleplayerButton_Click(object sender, EventArgs e)
        {
            Hide();
            levelMenu = new LevelMenu(this, 2, p1keys, p2keys);
            levelMenu.Show();
            levelMenu.Closed += (s, args) => { Show(); };
        }

        private void multiplayerButton_Click(object sender, EventArgs e)
        {
            Hide();
            levelMenu = new LevelMenu(this, 3, p1keys, p2keys);
            levelMenu.Show();
            levelMenu.Closed += (s, args) => { Show(); };
        }

        private void scoreboardButton_Click(object sender, EventArgs e)
        {
            Hide();
            scoreboardForm = new ScoreboardForm(this);
            scoreboardForm.Show();
            scoreboardForm.Closed += (s, args) => { Show(); };
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Hide();
            settingsForm = new Settings(this, p1keys, p2keys);
            settingsForm.Show();
            settingsForm.Closed += (s, args) => { Show(); };
        }

        private void createTable()
        {
            string relativePath = @"Database.sqlite";
            var parentDirectory = Path.GetDirectoryName(Application.StartupPath);
            string absolutePath = Path.Combine(parentDirectory, relativePath);
            // provjera postoji li baza
            // ako ne postoji stvorimo novu
            if (! File.Exists(absolutePath))
            {
                SQLiteConnection.CreateFile(absolutePath);
            }
            var connection = new SQLiteConnection("URI=file:"+absolutePath);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = "SELECT name FROM sqlite_master WHERE name='tablica'";
            var check = command.ExecuteScalar();
            // provjera postoji li tablica s imenom "tablica"
            // ako postoji izađemo, inače stvorimo novu
            if (check != null && check.ToString() == "tablica")
            {               
                return;
            }
            command.CommandText = "CREATE TABLE tablica (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, type INT, level INT, name VARCHAR(12), score INT)";
            command.ExecuteNonQuery();           
        }

    }
}
