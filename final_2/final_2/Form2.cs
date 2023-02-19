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
    public partial class Form2 : Form
    {
        String connectionString = "Data source=Player_list.db;Version=3";
        SQLiteConnection connection;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String createSQL = "Create table if not exists Players(Player_ID integer primary key autoincrement," +
                "First_Name Text,Last_Name Text,Username text)";
            SQLiteCommand command = new SQLiteCommand(createSQL, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            String selectSQL = "Select * from Players";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(3) == textBox3.Text)
                {
                    goto Error;
                }
            }
            String insertSQL = "Insert into Players(First_Name,Last_Name,Username) values(@firstname,@lastname,@username)";
            SQLiteCommand command2 = new SQLiteCommand(insertSQL, connection);
            command2.Parameters.AddWithValue("firstname", textBox1.Text);
            command2.Parameters.AddWithValue("lastname", textBox2.Text);
            command2.Parameters.AddWithValue("username", textBox3.Text);
            command2.ExecuteNonQuery();
            connection.Close();
            this.Close();
            Error:
                label5.Visible = true;
                connection.Close();
        }
    }
}
