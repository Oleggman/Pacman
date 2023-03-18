using System;
using Pacman.Controllers;
using Microsoft.Data.Sqlite;

namespace Pacman
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitDb();
            InitializeComponent();
            MediaController.Get().Update(GameDbContext.GetContext().GetSoundSettings());
            InitMaze();
        }

        private List<Panel> walls = null;
        private GameController gameController;

        private void InitMaze()
        {
            walls = new List<Panel>();

            var wall1 = new Panel();
            wall1.BackColor = Color.Black;
            wall1.Location = new Point(20, PanelGrid.Size.Height / 2);
            wall1.Size = new Size(20, 120);
            wall1.BackgroundImage = Properties.Resources.Wall;
            wall1.BackgroundImageLayout = ImageLayout.Stretch;
            PanelGrid.Controls.Add(wall1);
            walls.Add(wall1);

            var wall2 = new Panel();
            wall2.BackColor = Color.Black;
            wall2.Location = new Point(100, 0);
            wall2.Size = new Size(300, 30);
            wall2.BackgroundImage = Properties.Resources.Wall;
            wall2.BackgroundImageLayout = ImageLayout.Stretch;
            PanelGrid.Controls.Add(wall2);
            walls.Add(wall2);

            var wall3 = new Panel();
            wall3.BackColor = Color.Black;
            wall3.Location = new Point(100, PanelGrid.Size.Height - 30);
            wall3.Size = new Size(300, 30);
            wall3.BackgroundImage = Properties.Resources.Wall;
            wall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            PanelGrid.Controls.Add(wall3);
            walls.Add(wall3);
        }

        static SqliteConnection dbConnection = null;
        private void InitDb()
        {
            var connection = new SqliteConnection("Data Source=testgame.db");
            connection.Open();
            dbConnection = connection;
            SqliteCommand command = new SqliteCommand();
            command.Connection = dbConnection;
            command.CommandText = "CREATE TABLE IF NOT EXISTS"
                                + " game(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, "
                                + "playerX INTEGER NOT NULL, "
                                + "playerY INTEGER NOT NULL, "
                                + "ballX INTEGER NOT NULL, "
                                + "ballY INTEGER NOT NULL, "
                                + "score INTEGER NOT NULL)";
            command.ExecuteNonQuery();
        }

        private int score = 0;
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            ChangeLocation(e.KeyCode);

            Teleport();

            foreach (var wall in walls)
            {
                if (PacmanSprite.Bounds.IntersectsWith(wall.Bounds))
                {
                    KeyEventArgs evt = null;
                    switch (e.KeyCode)
                    {
                        case Keys.W: evt = new KeyEventArgs(Keys.S); break;
                        case Keys.A: evt = new KeyEventArgs(Keys.D); break;
                        case Keys.S: evt = new KeyEventArgs(Keys.W); break;
                        case Keys.D: evt = new KeyEventArgs(Keys.A); break;
                    }
                    MainForm_KeyDown(sender, evt);
                    return;
                }
            }

            UpdateScore();
        }

        private void ChangeLocation(Keys key)
        {
            switch (key)
            {
                case Keys.W: 
                    PacmanSprite.Location = new Point(PacmanSprite.Location.X, PacmanSprite.Location.Y - 10);
                    PacmanSprite.Image = Properties.Resources.Pacman_sprite_up_gif;
                    break;
                case Keys.A:
                    PacmanSprite.Location = new Point(PacmanSprite.Location.X - 10, PacmanSprite.Location.Y);
                    PacmanSprite.Image = Properties.Resources.Pacman_sprite_left_gif;
                    break;
                case Keys.S:
                    PacmanSprite.Location = new Point(PacmanSprite.Location.X, PacmanSprite.Location.Y + 10);
                    PacmanSprite.Image = Properties.Resources.Pacman_sprite_down_gif;
                    break;
                case Keys.D:
                    PacmanSprite.Location = new Point(PacmanSprite.Location.X + 10, PacmanSprite.Location.Y);
                    PacmanSprite.Image = Properties.Resources.Pacman_sprite_gif;
                    break;
            }
        }

        private void Teleport()
        {
            if (PacmanSprite.Location.Y > PanelGrid.Height - PacmanSprite.Height / 2)
                PacmanSprite.Location = new Point(PacmanSprite.Location.X, -PacmanSprite.Height / 2);
            else if (PacmanSprite.Location.Y < -(PacmanSprite.Height / 2))
                PacmanSprite.Location = new Point(PacmanSprite.Location.X, PanelGrid.Height - PacmanSprite.Height / 2);

            if (PacmanSprite.Location.X > PanelGrid.Width - PacmanSprite.Width / 2)
                PacmanSprite.Location = new Point(-PacmanSprite.Width / 2, PacmanSprite.Location.Y);
            else if (PacmanSprite.Location.X < -(PacmanSprite.Width / 2))
                PacmanSprite.Location = new Point(PanelGrid.Width - PacmanSprite.Width / 2, PacmanSprite.Location.Y);
        }

        private void UpdateScore()
        {
            if (PacmanSprite.Bounds.IntersectsWith(EnemySprite.Bounds))
            {
                SpawnPoint();
                score++;
                LabelScore.Text = "Score: " + score;
            }
        }

        private void SpawnPoint()
        {
            var rand = new Random();
            EnemySprite.Location = new Point(rand.Next(0, PanelGrid.Width - EnemySprite.Width),
                                             rand.Next(0, PanelGrid.Height - EnemySprite.Height));

            foreach (var wall in walls)
            {
                if (EnemySprite.Bounds.IntersectsWith(wall.Bounds))
                {
                    SpawnPoint();
                    return;
                }
            }
        }

        void LoadInfo(int playerX, int playerY, int ballX, int ballY, int score)
        {
            PacmanSprite.Location = new Point(playerX, playerY);
            EnemySprite.Location = new Point(ballX, ballY);
            this.score = score;
            LabelScore.Text = "Score: " + score;
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            gameController = new GameController(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Made by ukrainian student\n" +
                "Under the guidanse of DDL laboratory\n" +
                "\n\tKovalets Oleg\n" +
                "\tKyiv, Ukraine\n" +
                "\t\t\t2023",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqliteCommand dbInsVersion = new SqliteCommand();
            dbInsVersion.Connection = dbConnection;
            dbInsVersion.CommandText = $"INSERT INTO game(playerX, playerY, ballX, ballY, score) " +
                                       $"VALUES({PacmanSprite.Location.X}, {PacmanSprite.Location.Y} ," +
                                       $"{EnemySprite.Location.X}, {EnemySprite.Location.Y}, {score})";
            dbInsVersion.ExecuteNonQuery();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqliteCommand selectCommand = new SqliteCommand();
            selectCommand.Connection = dbConnection;
            selectCommand.CommandText = "SELECT * FROM game WHERE id = (SELECT MAX(id) FROM game); ";
            using (var reader = selectCommand.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        //var id = reader.GetValue(0);
                        var playerX = Convert.ToInt32(reader.GetValue(1));
                        var playerY = Convert.ToInt32(reader.GetValue(2));
                        var ballX = Convert.ToInt32(reader.GetValue(3));
                        var ballY = Convert.ToInt32(reader.GetValue(4));
                        var score = Convert.ToInt32(reader.GetValue(5));
                        LoadInfo(playerX, playerY, ballX, ballY, score);
                    }
                }
            }
        }

        private void soundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enabled = false;
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void nextLeveltestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameController.NextLevel();
        }
    }
}