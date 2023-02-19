using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment1_Ναυμαχία_
{
    public partial class Form1 : Form
    {
        String connectionString = "Data source =csharp2023_1.db;Version=3";
        List<Ships> MyShips = new List<Ships>();
        List<Ships> EnemyShips = new List<Ships>();
        List<PictureBox> MyUIgrid = new List<PictureBox>();
        List<PictureBox> EnemyUIgrid = new List<PictureBox>();
        int TimeElapsed = 0;
        int count = 1;
        int myShipsSunk = 0;
        int enemyShipsSunk = 0;       
        Player p1 = new Player();
        Player p2 = new Player();
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        bool[] MyGridhits = new bool[100];
        bool[] EnemyGridhits = new bool[100];
        bool[] MyShipsPos = new bool[100];
        bool[] EnemyShipsPos = new bool[100];
        public void load()
        {
            MyUIgrid.Add(pictureBox3);
            MyUIgrid.Add(pictureBox4);
            MyUIgrid.Add(pictureBox5);
            MyUIgrid.Add(pictureBox6);
            MyUIgrid.Add(pictureBox7);
            MyUIgrid.Add(pictureBox8);
            MyUIgrid.Add(pictureBox9);
            MyUIgrid.Add(pictureBox10);
            MyUIgrid.Add(pictureBox11);
            MyUIgrid.Add(pictureBox12);
            MyUIgrid.Add(pictureBox13);
            MyUIgrid.Add(pictureBox14);
            MyUIgrid.Add(pictureBox15);
            MyUIgrid.Add(pictureBox16);
            MyUIgrid.Add(pictureBox17);
            MyUIgrid.Add(pictureBox18);
            MyUIgrid.Add(pictureBox19);
            MyUIgrid.Add(pictureBox20);
            MyUIgrid.Add(pictureBox21);
            MyUIgrid.Add(pictureBox22);
            MyUIgrid.Add(pictureBox23);
            MyUIgrid.Add(pictureBox24);
            MyUIgrid.Add(pictureBox25);
            MyUIgrid.Add(pictureBox26);
            MyUIgrid.Add(pictureBox27);
            MyUIgrid.Add(pictureBox28);
            MyUIgrid.Add(pictureBox29);
            MyUIgrid.Add(pictureBox30);
            MyUIgrid.Add(pictureBox31);
            MyUIgrid.Add(pictureBox32);
            MyUIgrid.Add(pictureBox33);
            MyUIgrid.Add(pictureBox34);
            MyUIgrid.Add(pictureBox35);
            MyUIgrid.Add(pictureBox36);
            MyUIgrid.Add(pictureBox37);
            MyUIgrid.Add(pictureBox38);
            MyUIgrid.Add(pictureBox39);
            MyUIgrid.Add(pictureBox40);
            MyUIgrid.Add(pictureBox41);
            MyUIgrid.Add(pictureBox42);
            MyUIgrid.Add(pictureBox43);
            MyUIgrid.Add(pictureBox44);
            MyUIgrid.Add(pictureBox45);
            MyUIgrid.Add(pictureBox46);
            MyUIgrid.Add(pictureBox47);
            MyUIgrid.Add(pictureBox48);
            MyUIgrid.Add(pictureBox49);
            MyUIgrid.Add(pictureBox50);
            MyUIgrid.Add(pictureBox51);
            MyUIgrid.Add(pictureBox52);
            MyUIgrid.Add(pictureBox53);
            MyUIgrid.Add(pictureBox54);
            MyUIgrid.Add(pictureBox55);
            MyUIgrid.Add(pictureBox56);
            MyUIgrid.Add(pictureBox57);
            MyUIgrid.Add(pictureBox58);
            MyUIgrid.Add(pictureBox59);
            MyUIgrid.Add(pictureBox60);
            MyUIgrid.Add(pictureBox61);
            MyUIgrid.Add(pictureBox62);
            MyUIgrid.Add(pictureBox63);
            MyUIgrid.Add(pictureBox64);
            MyUIgrid.Add(pictureBox65);
            MyUIgrid.Add(pictureBox66);
            MyUIgrid.Add(pictureBox67);
            MyUIgrid.Add(pictureBox68);
            MyUIgrid.Add(pictureBox69);
            MyUIgrid.Add(pictureBox70);
            MyUIgrid.Add(pictureBox71);
            MyUIgrid.Add(pictureBox72);
            MyUIgrid.Add(pictureBox73);
            MyUIgrid.Add(pictureBox74);
            MyUIgrid.Add(pictureBox75);
            MyUIgrid.Add(pictureBox76);
            MyUIgrid.Add(pictureBox77);
            MyUIgrid.Add(pictureBox78);
            MyUIgrid.Add(pictureBox79);
            MyUIgrid.Add(pictureBox80);
            MyUIgrid.Add(pictureBox81);
            MyUIgrid.Add(pictureBox82);
            MyUIgrid.Add(pictureBox83);
            MyUIgrid.Add(pictureBox84);
            MyUIgrid.Add(pictureBox85);
            MyUIgrid.Add(pictureBox86);
            MyUIgrid.Add(pictureBox87);
            MyUIgrid.Add(pictureBox88);
            MyUIgrid.Add(pictureBox89);
            MyUIgrid.Add(pictureBox90);
            MyUIgrid.Add(pictureBox91);
            MyUIgrid.Add(pictureBox92);
            MyUIgrid.Add(pictureBox93);
            MyUIgrid.Add(pictureBox94);
            MyUIgrid.Add(pictureBox95);
            MyUIgrid.Add(pictureBox96);
            MyUIgrid.Add(pictureBox97);
            MyUIgrid.Add(pictureBox98);
            MyUIgrid.Add(pictureBox99);
            MyUIgrid.Add(pictureBox100);
            MyUIgrid.Add(pictureBox101);
            MyUIgrid.Add(pictureBox102);
            EnemyUIgrid.Add(pictureBox103);
            EnemyUIgrid.Add(pictureBox104);
            EnemyUIgrid.Add(pictureBox105);
            EnemyUIgrid.Add(pictureBox106);
            EnemyUIgrid.Add(pictureBox107);
            EnemyUIgrid.Add(pictureBox108);
            EnemyUIgrid.Add(pictureBox109);
            EnemyUIgrid.Add(pictureBox110);
            EnemyUIgrid.Add(pictureBox111);
            EnemyUIgrid.Add(pictureBox112);
            EnemyUIgrid.Add(pictureBox113);
            EnemyUIgrid.Add(pictureBox114);
            EnemyUIgrid.Add(pictureBox115);
            EnemyUIgrid.Add(pictureBox116);
            EnemyUIgrid.Add(pictureBox117);
            EnemyUIgrid.Add(pictureBox118);
            EnemyUIgrid.Add(pictureBox119);
            EnemyUIgrid.Add(pictureBox120);
            EnemyUIgrid.Add(pictureBox121);
            EnemyUIgrid.Add(pictureBox122);
            EnemyUIgrid.Add(pictureBox123);
            EnemyUIgrid.Add(pictureBox124);
            EnemyUIgrid.Add(pictureBox125);
            EnemyUIgrid.Add(pictureBox126);
            EnemyUIgrid.Add(pictureBox127);
            EnemyUIgrid.Add(pictureBox128);
            EnemyUIgrid.Add(pictureBox129);
            EnemyUIgrid.Add(pictureBox130);
            EnemyUIgrid.Add(pictureBox131);
            EnemyUIgrid.Add(pictureBox132);
            EnemyUIgrid.Add(pictureBox133);
            EnemyUIgrid.Add(pictureBox134);
            EnemyUIgrid.Add(pictureBox135);
            EnemyUIgrid.Add(pictureBox136);
            EnemyUIgrid.Add(pictureBox137);
            EnemyUIgrid.Add(pictureBox138);
            EnemyUIgrid.Add(pictureBox139);
            EnemyUIgrid.Add(pictureBox140);
            EnemyUIgrid.Add(pictureBox141);
            EnemyUIgrid.Add(pictureBox142);
            EnemyUIgrid.Add(pictureBox143);
            EnemyUIgrid.Add(pictureBox144);
            EnemyUIgrid.Add(pictureBox145);
            EnemyUIgrid.Add(pictureBox146);
            EnemyUIgrid.Add(pictureBox147);
            EnemyUIgrid.Add(pictureBox148);
            EnemyUIgrid.Add(pictureBox149);
            EnemyUIgrid.Add(pictureBox150);
            EnemyUIgrid.Add(pictureBox151);
            EnemyUIgrid.Add(pictureBox152);
            EnemyUIgrid.Add(pictureBox153);
            EnemyUIgrid.Add(pictureBox154);
            EnemyUIgrid.Add(pictureBox155);
            EnemyUIgrid.Add(pictureBox156);
            EnemyUIgrid.Add(pictureBox157);
            EnemyUIgrid.Add(pictureBox158);
            EnemyUIgrid.Add(pictureBox159);
            EnemyUIgrid.Add(pictureBox160);
            EnemyUIgrid.Add(pictureBox161);
            EnemyUIgrid.Add(pictureBox162);
            EnemyUIgrid.Add(pictureBox163);
            EnemyUIgrid.Add(pictureBox164);
            EnemyUIgrid.Add(pictureBox165);
            EnemyUIgrid.Add(pictureBox166);
            EnemyUIgrid.Add(pictureBox167);
            EnemyUIgrid.Add(pictureBox168);
            EnemyUIgrid.Add(pictureBox169);
            EnemyUIgrid.Add(pictureBox170);
            EnemyUIgrid.Add(pictureBox171);
            EnemyUIgrid.Add(pictureBox172);
            EnemyUIgrid.Add(pictureBox173);
            EnemyUIgrid.Add(pictureBox174);
            EnemyUIgrid.Add(pictureBox175);
            EnemyUIgrid.Add(pictureBox176);
            EnemyUIgrid.Add(pictureBox177);
            EnemyUIgrid.Add(pictureBox178);
            EnemyUIgrid.Add(pictureBox179);
            EnemyUIgrid.Add(pictureBox180);
            EnemyUIgrid.Add(pictureBox181);
            EnemyUIgrid.Add(pictureBox182);
            EnemyUIgrid.Add(pictureBox183);
            EnemyUIgrid.Add(pictureBox184);
            EnemyUIgrid.Add(pictureBox185);
            EnemyUIgrid.Add(pictureBox186);
            EnemyUIgrid.Add(pictureBox187);
            EnemyUIgrid.Add(pictureBox188);
            EnemyUIgrid.Add(pictureBox189);
            EnemyUIgrid.Add(pictureBox190);
            EnemyUIgrid.Add(pictureBox191);
            EnemyUIgrid.Add(pictureBox192);
            EnemyUIgrid.Add(pictureBox193);
            EnemyUIgrid.Add(pictureBox194);
            EnemyUIgrid.Add(pictureBox195);
            EnemyUIgrid.Add(pictureBox196);
            EnemyUIgrid.Add(pictureBox197);
            EnemyUIgrid.Add(pictureBox198);
            EnemyUIgrid.Add(pictureBox199);
            EnemyUIgrid.Add(pictureBox200);
            EnemyUIgrid.Add(pictureBox201);
            EnemyUIgrid.Add(pictureBox202);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            load();
            button1.Visible = false;
            timer1.Enabled = true;
            label42.Visible = true;
            p1.Setup(MyShips, MyShipsPos);
            foreach (Ships s in MyShips)
            {
                for (int i = 0; i<100; i++)
                {
                    
                    if (MyShipsPos[i] == true)
                    {
                        MyUIgrid[i].Visible = true;
                        MyUIgrid[i].ImageLocation = "Ship.png";
                    }
                }
            }
            
            button2.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeElapsed += 1;
            label41.Text = TimeElapsed.ToString() + " sec";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                p2.Setup(EnemyShips, EnemyShipsPos);
                count += 1;
            }
            int x = Int32.Parse(textBox1.Text);
            int y = 0;
            string[] CharToNum = { "Α", "Β", "Γ", "Δ", "Ε", "Ζ", "Η", "Θ", "Ι", "Κ" };
            for (int i = 0; i <= 9; i++)
            {
                if (CharToNum[i] == textBox2.Text)
                {
                    y = i + 1;
                }
            }
            if (y != 0)
            {
                if (EnemyGridhits[(y - 1) * 10 + x - 1] == false)
                {

                    p1.Hit(EnemyGridhits, EnemyShips, x, y);
                    foreach (Ships s in EnemyShips)
                    {
                        if (s.TileSize == 0)
                        {
                            s.TileSize = -1;
                            enemyShipsSunk += 1;
                            score += 100;
                            label42.Text = "Βυθίστικε το αντίπαλο " + s.Name;
                        }
                    }
                    if (EnemyShipsPos[(y - 1) * 10 + x - 1] == true)
                    {
                        EnemyUIgrid[(y - 1) * 10 + x - 1].Visible = true;
                        EnemyUIgrid[(y - 1) * 10 + x - 1].ImageLocation = "Hit.png";
                    }
                    else
                    {
                        EnemyUIgrid[(y - 1) * 10 + x - 1].Visible = true;
                        EnemyUIgrid[(y - 1) * 10 + x - 1].ImageLocation = "Miss.png";
                    }

                    if (enemyShipsSunk == 4)
                    {
                        button3.Enabled = false;
                        button2.Enabled = false;
                        label42.Text = "Congratulations! you have Won the game! Score:" + score;
                    }
                    EnemyGridhits[(y - 1) * 10 + x - 1] = true;
                    button3.Enabled = true;
                    button2.Enabled = false;
                }else
                {
                    label42.Text = "Please select different coordinates as you have already attacked the ones given";
                }
            }else
            {
                label42.Text = "Invalid target, please use the correct language and capitalization";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = r.Next(1, 11);
            int y = r.Next(1, 11);
            while (MyGridhits[(y - 1) * 10 + x - 1] == true)
            {
                x = r.Next(1, 11);
                y = r.Next(1, 11);
            }
            int pos = (y - 1) * 10 + x - 1;
            p2.Hit(MyGridhits, MyShips, x, y);
            foreach (Ships s in MyShips)
            {
                if (s.TileSize == 0)
                {
                    s.TileSize = -1; 
                    myShipsSunk += 1;
                    score -= 100;
                    label42.Text = "Βυθίστικε το " + s.Name+"σας!";
                }
            }
            if (MyShipsPos[pos] == true)
            {
                MyUIgrid[(y - 1) * 10 + x - 1].Visible = true;
                MyUIgrid[(y - 1) * 10 + x - 1].ImageLocation = "Hit.png";
            }
            else
            {
                MyUIgrid[pos].Visible = true;
                MyUIgrid[pos].ImageLocation = "Miss.png";
            }
            if (myShipsSunk == 4)
            {
                button3.Enabled = false;
                button2.Enabled = false;
                label42.Text = "You lost to the Computer, Better Luck next time!";
            }
            MyGridhits[(y - 1) * 10 + x - 1] = true;
            button2.Enabled = true;
            button3.Enabled = false;
        }
    }
}
