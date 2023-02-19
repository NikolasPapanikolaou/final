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

namespace final_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Leaderboard ld = new Leaderboard(richTextBox1);
            ld.DisplayScores();
        }

        class Leaderboard
        {
            private SQLiteConnection connection;
            private RichTextBox richTextBox;

            public Leaderboard(RichTextBox rtb)
            {
                connection = new SQLiteConnection("Data Source=Player_scores.db;Version=3;");
                richTextBox = rtb;
            }

            public void DisplayScores()
            {
                connection.Open();
                // Retrieve the highest score and corresponding username
                String selectSQL = "SELECT Username, MAX(Score) as Score FROM Scores";
                SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                reader.Read();
                richTextBox.AppendText("Highest Score: " + reader.GetInt32(1) + " by " + reader.GetString(0) + Environment.NewLine);

                // Retrieve the top 10 scores and corresponding usernames
                selectSQL = "SELECT Username, Score FROM Scores ORDER BY Score DESC LIMIT 10";
                command = new SQLiteCommand(selectSQL, connection);
                reader = command.ExecuteReader();
                richTextBox.AppendText("Top 10 Scores:" + Environment.NewLine);
                while (reader.Read())
                {
                    richTextBox.AppendText(reader.GetString(0) + " - " + reader.GetInt32(1) + Environment.NewLine);
                }
                connection.Close();
            }
        }

    }
}
