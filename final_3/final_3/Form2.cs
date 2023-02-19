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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        class Client
        {
            private SQLiteConnection connection;

            public Client()
            {
                // Connect to the database
                connection = new SQLiteConnection("Data Source=clients.db;Version=3;");
            }

            public void SaveClient(string fullName, string email, string phone, string dateOfBirth, string requestType, string address, string dateTime)
            {
                connection.Open();
                String createSQL = "Create table if not exists Clients(Client_ID integer primary key autoincrement," +
                "Full_Name Text,Email Text,Phone Text,Date_Of_Birth Text,Request_Type Text,Address Text,Date_Time Text)";
                SQLiteCommand command = new SQLiteCommand(createSQL, connection);
                command.ExecuteNonQuery();
                String insertSQL = "Insert into Clients(Full_Name,Email,Phone,Date_Of_Birth,Request_Type,Address,Date_Time) values(@fullname,@email,@phone,@dateofbirth,@requesttype,@address,@datetime)";
                SQLiteCommand command2 = new SQLiteCommand(insertSQL, connection);
                command2.Parameters.AddWithValue("fullname", fullName);
                command2.Parameters.AddWithValue("email", email);
                command2.Parameters.AddWithValue("phone", phone);
                command2.Parameters.AddWithValue("dateofbirth", dateOfBirth);
                command2.Parameters.AddWithValue("requesttype", requestType);
                command2.Parameters.AddWithValue("address", address);
                command2.Parameters.AddWithValue("datetime", dateTime);
                command2.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateAndTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Client client = new Client();
            client.SaveClient(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, dateAndTime);
            label8.Visible = true;
            this.Close();
        }
    }
}
