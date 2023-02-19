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
    public partial class Form5 : Form
    {
        public Form5()
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
                        richTextBox1.AppendText(" Phone: " + reader.GetString(3));
                        richTextBox1.AppendText("-");
                        richTextBox1.AppendText(" Date of Birth: " + reader.GetString(4));
                        richTextBox1.AppendText("-");
                        richTextBox1.AppendText(" Request Type: " + reader.GetString(5));
                        richTextBox1.AppendText("-");
                        richTextBox1.AppendText(" Address: " + reader.GetString(6));
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

            public void EditClient(int id, string fullName, string email, string phone, string dateOfBirth, string requestType, string address, string dateTime)
            {
                connection.Open();
                String updateSQL = "UPDATE Clients SET Full_Name = @fullName, Email = @email, Phone = @phone, Date_Of_Birth = @dateOfBirth, Request_Type = @requestType, Address = @address, Date_Time = @dateTime WHERE Client_ID = @id";
                SQLiteCommand command = new SQLiteCommand(updateSQL, connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("fullName", fullName);
                command.Parameters.AddWithValue("email", email);
                command.Parameters.AddWithValue("phone", phone);
                command.Parameters.AddWithValue("dateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("requestType", requestType);
                command.Parameters.AddWithValue("address", address);
                command.Parameters.AddWithValue("dateTime", dateTime);
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
            string dateAndTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Client cl2 = new Client(richTextBox1);
            cl2.EditClient(Int32.Parse(textBox8.Text),textBox7.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text, dateAndTime);
            label11.Visible = true;
        }
    }
}
