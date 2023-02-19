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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace final_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        class Request
        {
            private SQLiteConnection connection;
            private RichTextBox richTextBox1;

            public Request(RichTextBox rtb)
            {
                connection = new SQLiteConnection("Data Source=clients.db;Version=3;");
                richTextBox1 = rtb;
            }

            public void PrintAllRequests()
            {
                connection.Open();
                // Retrieve all requests
                String selectSQL = "SELECT * FROM Clients";
                SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                richTextBox1.AppendText("All Requests:");
                richTextBox1.AppendText(Environment.NewLine);
                while (reader.Read())
                {
                    richTextBox1.AppendText("ID: " + reader.GetInt32(0));
                    richTextBox1.AppendText("-");
                    richTextBox1.AppendText(" Citizen: " + reader.GetString(1));
                    richTextBox1.AppendText("-");
                    richTextBox1.AppendText(" E-mail: " + reader.GetString(2));
                    richTextBox1.AppendText("-");
                    richTextBox1.AppendText(" Request Type: " + reader.GetString(5));
                    richTextBox1.AppendText("-");
                    richTextBox1.AppendText(" Date / Time: " + reader.GetString(7));
                    richTextBox1.AppendText(Environment.NewLine);
                }
                connection.Close();
            }
            public void PrintRequestsPerCitizen(string citizen)
            {
                connection.Open();
                // Retrieve all requests by citizen
                String selectSQL = "SELECT * FROM Clients WHERE Full_Name like @fullname";
                SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
                command.Parameters.AddWithValue("fullname", citizen);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    richTextBox1.AppendText("ID: " + reader.GetInt32(0));
                    richTextBox1.AppendText("-");
                    richTextBox1.AppendText(" Citizen: " + reader.GetString(1));
                    richTextBox1.AppendText("-");
                    richTextBox1.AppendText(" E-mail: " + reader.GetString(2));
                    richTextBox1.AppendText("-");
                    richTextBox1.AppendText(" Request Type: " + reader.GetString(5));
                    richTextBox1.AppendText("-");
                    richTextBox1.AppendText(" Date / Time: " + reader.GetString(7));
                    richTextBox1.AppendText(Environment.NewLine);
                }
                connection.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Request rq = new Request(richTextBox2);
            rq.PrintAllRequests();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Request rq2 = new Request(richTextBox1);
            rq2.PrintRequestsPerCitizen(textBox1.Text);
        }
    }
}
