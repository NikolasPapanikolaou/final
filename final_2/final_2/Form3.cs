using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace final_2
{
    public partial class Form3 : Form
    {
        public int timeLeft;
        Timer countdownTimer;
        string Username;
        int Level;
        int score;
        public Form3(string username, int level)
        {
            InitializeComponent();
            Username = username;
            Level = level;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            toolStripTextBox2.Text = Username.ToString();
            toolStripTextBox4.Text = Level.ToString();
        }

        private int getSpeed()
        {
            if (Level == 2)
            {
                return (900);
            }
            else if (Level == 3)
            {
                return (600);
            }
            return (1000);
        }

        class Butterfly
        {
            private PictureBox picButterfly;
            private Timer timer;

            public PictureBox PicButterfly
            {
                get { return picButterfly; }
            }
            public Butterfly(int speed)
            {

                picButterfly = new PictureBox();
                picButterfly.ImageLocation = "butterfly.png";
                picButterfly.Size = new Size(50, 50);
                picButterfly.SizeMode = PictureBoxSizeMode.StretchImage;

                timer = new Timer();
                timer.Interval = speed;
                timer.Tick += Timer_Tick;
                timer.Start();
            }

            private void Timer_Tick(object sender, EventArgs e)
            {
                Move();
            }

            public void Move()
            {
                Random rnd = new Random();
                int x = rnd.Next(0, picButterfly.Parent.Width - picButterfly.Width);
                int y = rnd.Next(0, picButterfly.Parent.Height - picButterfly.Height);
                picButterfly.Location = new Point(x, y);
            }
        }

        class Database
        {
            private SQLiteConnection connection;

            public Database()
            {
                // Connect to the database
                connection = new SQLiteConnection("Data Source=Player_scores.db;Version=3;");
            }

            public void InsertPlayer(string username, int score)
            {
                connection.Open();
                String createSQL = "Create table if not exists Scores(Score_ID integer primary key autoincrement," +
                "Username Text,Score integer)";
                SQLiteCommand command = new SQLiteCommand(createSQL, connection);
                command.ExecuteNonQuery();
                String insertSQL = "Insert into Scores(Username,Score) values(@username,@score)";
                SQLiteCommand command2 = new SQLiteCommand(insertSQL, connection);
                command2.Parameters.AddWithValue("username", username);
                command2.Parameters.AddWithValue("score", score);
                command2.ExecuteNonQuery();
                connection.Close();
                return;
            }
        }

        private void Butterfly_MouseEnter(object sender, EventArgs e)
        {
            score++;
            toolStripTextBox5.Text = score.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            Butterfly butterfly = new Butterfly(getSpeed());
            this.Controls.Add(butterfly.PicButterfly);
            butterfly.PicButterfly.MouseEnter += Butterfly_MouseEnter;

            // Initialize the countdown timer
            timeLeft = 120 / Level;
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Update the time left label
            timeLeft--;
            toolStripTextBox8.Text = timeLeft.ToString();

            // Check if the time left is zero
            if (timeLeft == 0)
            {
                // Stop the timer
                countdownTimer.Stop();
                Database db = new Database();
                db.InsertPlayer(Username, score);
                this.Close();
            }
        }
    }
}
