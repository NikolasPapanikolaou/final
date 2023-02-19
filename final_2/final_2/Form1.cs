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

namespace final_2
{
    public partial class Form1 : Form
    {
        public int level = 1;
        String connectionString = "Data source=Player_list.db;Version=3";
        SQLiteConnection connection;
        Boolean login = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String createSQL = "Create table if not exists Players(Player_ID integer primary key autoincrement," +
                "First_Name Text,Last_Name Text,Username text)";
            SQLiteCommand command = new SQLiteCommand(createSQL, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
            label2.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            level = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Green;
            label7.ForeColor = Color.Black;
            level = 2;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label7.ForeColor = Color.Green;
            level = 3;
        }
        private void nEWPLAYERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            String selectSQL = "Select * from Players";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(3) == textBox1.Text)
                {
                    connection.Close();
                    login = true;
                    Form3 form3 = new Form3((textBox1.Text).ToString(),level);
                    form3.ShowDialog();
                    break;
                }
            }
            if (login == false)
            {
                connection.Close();
                label6.Visible = true;
            }
        }

        private void sCORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
