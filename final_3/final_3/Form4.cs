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

namespace final_3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        class Client
        {
            private SQLiteConnection connection;
            private RichTextBox richTextBox1;

            public Client(RichTextBox rtb)
            {
                connection = new SQLiteConnection("Data Source=clients.db;Version=3;");
                richTextBox1 = rtb;
            }

            public void SearchClient(string searchTerm)
            {
                connection.Open();
                String selectSQL = "SELECT * FROM Clients WHERE Full_Name = @searchTerm OR Email = @searchTerm OR Request_Type = @searchTerm";
                SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
                command.Parameters.AddWithValue("searchTerm", searchTerm);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
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
                }
                else
                {
                    richTextBox1.AppendText("No clients found with that name, email or request type.");
                }
                connection.Close();
            }

            public void DeleteClient(int id)
            {
                connection.Open();
                String deleteSQL = "DELETE FROM Clients WHERE Client_ID = @id";
                SQLiteCommand command = new SQLiteCommand(deleteSQL, connection);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client cl = new Client(richTextBox1);
            cl.SearchClient(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client cl2 = new Client(richTextBox1);
            cl2.DeleteClient(Int32.Parse(textBox2.Text));
            label8.Visible = true;
        }
    }
}
