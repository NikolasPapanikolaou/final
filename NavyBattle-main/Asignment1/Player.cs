using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment1_Ναυμαχία_
{
    public class Player
    {
        Random r = new Random();

        public void Setup(List<Ships> enemyships, bool[] grid)
        {
            int pIndex;
            Ships s1 = new Ships();
            s1.Name = "Αεροπλανοφόρο";
            s1.TileSize = 5;
            int LocX = r.Next(1, 11);
            int LocY = r.Next(1, 11);
            s1.LocationXstart = LocX;
            s1.LocationYstart = LocY;
            if (LocX - 4 < 1 && LocY - 4 < 1)
            {
                int[] Pos = { LocX + 4, LocY + 4 };
                pIndex = r.Next(Pos.Length);
                if (pIndex == 0)
                {
                    s1.LocationXend = Pos[0];
                    s1.LocationYend = LocY;
                    enemyships.Add(s1);
                }
                else
                {
                    s1.LocationXend = LocX;
                    s1.LocationYend = Pos[1];
                    enemyships.Add(s1);
                }
            }
            else if (LocX + 4 > 10 && LocY - 4 < 1)
            {
                int[] Pos = { LocX - 4, LocY + 4 };
                pIndex = r.Next(Pos.Length);
                if (pIndex == 0)
                {
                    s1.LocationXend = Pos[0];
                    s1.LocationYend = LocY;
                    enemyships.Add(s1);
                }
                else
                {
                    s1.LocationXend = LocX;
                    s1.LocationYend = Pos[1];
                    enemyships.Add(s1);
                }
            }
            else if (LocX - 4 < 1 && LocY + 4 > 10)
            {
                int[] Pos = { LocX + 4, LocY - 4 };
                pIndex = r.Next(Pos.Length);
                if (pIndex == 0)
                {
                    s1.LocationXend = Pos[0];
                    s1.LocationYend = LocY;
                    enemyships.Add(s1);
                }
                else
                {
                    s1.LocationXend = LocX;
                    s1.LocationYend = Pos[1];
                    enemyships.Add(s1);
                }
            }
            else if (LocX + 4 > 10 && LocY + 4 > 10)
            {
                int[] Pos = { LocX - 4, LocY - 4 };
                pIndex = r.Next(Pos.Length);
                if (pIndex == 0)
                {
                    s1.LocationXend = Pos[0];
                    s1.LocationYend = LocY;
                    enemyships.Add(s1);
                }
                else
                {
                    s1.LocationXend = LocX;
                    s1.LocationYend = Pos[1];
                    enemyships.Add(s1);
                }
            }
            else if (LocX - 4 < 1)
            {
                int[] Pos = { LocX + 4, LocY + 4, LocY - 4 };
                pIndex = r.Next(Pos.Length);
                if (pIndex == 0)
                {
                    s1.LocationXend = Pos[0];
                    s1.LocationYend = LocY;
                    enemyships.Add(s1);
                }
                else if (pIndex == 1)
                {
                    s1.LocationYend = Pos[1];
                    s1.LocationXend = LocX;
                    enemyships.Add(s1);
                }
                else
                {
                    s1.LocationXend = LocX;
                    s1.LocationYend = Pos[2];
                    enemyships.Add(s1);
                }
            }
            else if (LocY - 4 < 1)
            {
                int[] Pos = { LocX + 4, LocX - 4, LocY + 4 };
                pIndex = r.Next(Pos.Length);
                if (pIndex == 0)
                {
                    s1.LocationXend = Pos[0];
                    s1.LocationYend = LocY;
                    enemyships.Add(s1);
                }
                else if (pIndex == 1)
                {
                    s1.LocationXend = Pos[1];
                    s1.LocationYend = LocY;
                    enemyships.Add(s1);
                }
                else if (pIndex == 2)
                {
                    s1.LocationXend = LocX;
                    s1.LocationYend = Pos[2];
                    enemyships.Add(s1);
                }
            }
            else if (LocX + 4 > 10)
            {
                int[] Pos = { LocX - 4, LocY + 4, LocY - 4 };
                pIndex = r.Next(Pos.Length);
                if (pIndex == 0)
                {
                    s1.LocationXend = Pos[0];
                    s1.LocationYend = LocY;
                    enemyships.Add(s1);
                }
                else if (pIndex == 1)
                {
                    s1.LocationXend = LocX;
                    s1.LocationYend = Pos[1];
                    enemyships.Add(s1);
                }
                else if (pIndex == 2)
                {
                    s1.LocationXend = LocX;
                    s1.LocationYend = Pos[2];
                    enemyships.Add(s1);
                }
            }
            else if (LocY + 4 > 10)
            {
                int[] Pos = { LocX + 4, LocX - 4, LocY - 4 };
                pIndex = r.Next(Pos.Length);
                if (pIndex == 0)
                {
                    s1.LocationXend = Pos[0];
                    s1.LocationYend = LocY;
                    enemyships.Add(s1);
                }
                else if (pIndex == 1)
                {
                    s1.LocationXend = Pos[1];
                    s1.LocationYend = LocY;
                    enemyships.Add(s1);
                }
                else if (pIndex == 2)
                {
                    s1.LocationXend = LocX;
                    s1.LocationYend = Pos[2];
                    enemyships.Add(s1);
                }
            }
            else
            {
                int[] Pos = { LocX + 4, LocX - 4, LocY + 4, LocY - 4 };
                pIndex = r.Next(Pos.Length);
                if (pIndex == 0)
                {
                    s1.LocationXend = Pos[0];
                    s1.LocationYend = LocY;
                    enemyships.Add(s1);
                }
                else if (pIndex == 1)
                {
                    s1.LocationXend = Pos[1];
                    s1.LocationYend = LocY;
                    enemyships.Add(s1);
                }
                else if (pIndex == 2)
                {
                    s1.LocationXend = LocX;
                    s1.LocationYend = Pos[2];
                    enemyships.Add(s1);
                }else
                {
                    s1.LocationXend = LocX;
                    s1.LocationYend = Pos[3];
                    enemyships.Add(s1);
                }
            }
            if (s1.LocationXstart != s1.LocationXend)
            {
                s1.LocationYend = s1.LocationYstart;
            }

            if (s1.LocationXstart == s1.LocationXend)
            {
                if (s1.LocationYstart > s1.LocationYend)
                {
                    for (int i = s1.LocationYstart; i >= s1.LocationYend; i--)
                    {
                        grid[(i - 1) * 10 + s1.LocationXstart - 1] = true;
                    }
                }
                else if (s1.LocationYstart < s1.LocationYend)
                {
                    for (int i = s1.LocationYstart; i <= s1.LocationYend; i++)
                    {
                        grid[(i - 1) * 10 + s1.LocationXstart - 1] = true;
                    }
                }
            }
            else if (s1.LocationYstart == s1.LocationYend)
            {
                if (s1.LocationXstart > s1.LocationXend)
                {
                    for (int i = s1.LocationXstart; i >= s1.LocationXend; i--)
                    {
                        grid[(s1.LocationYstart - 1) * 10 + i - 1] = true;
                    }
                }
                else if (s1.LocationXstart < s1.LocationXend)
                {
                    for (int i = s1.LocationXstart; i <= s1.LocationXend; i++)
                    {
                        grid[(s1.LocationYstart - 1) * 10 + i - 1] = true;
                    }
                }
            }

            Ships s2 = new Ships();
            s2.Name = "Αντιτορπιλικό";
            s2.TileSize = 4;
            LocX = r.Next(1, 11);
            LocY = r.Next(1, 11);
            while (grid[((LocY - 1) * 10 + LocX) - 1] == true)
            {
                LocX = r.Next(1, 11);
                LocY = r.Next(1, 11);
            }
            s2.LocationXstart = LocX;
            s2.LocationYstart = LocY;
            if (LocX - 3 < 1 && LocY - 3 < 1)
            {
                int[] Pos = { LocX + 3, LocY + 3 };
                bool flag = false;
                for (int i = LocX; i <= LocX + 3; i++)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s2.LocationXend = Pos[0];
                    s2.LocationYend = LocY;
                    enemyships.Add(s2);
                }
                else
                {
                    s2.LocationXend = LocX;
                    s2.LocationYend = Pos[1];
                    enemyships.Add(s2);
                }
            }
            else if (LocX + 3 > 10 && LocY - 3 < 1)
            {
                int[] Pos = { LocX - 3, LocY + 3 };
                bool flag = false;
                for (int i = LocX; i >= LocX - 3; i--)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s2.LocationXend = Pos[0];
                    s2.LocationYend = LocY;
                    enemyships.Add(s2);
                }
                else
                {
                    s2.LocationXend = LocX;
                    s2.LocationYend = Pos[1];
                    enemyships.Add(s2);
                }
            } else if (LocX - 3 < 1 && LocY + 3 > 10)
            {
                int[] Pos = { LocX + 3, LocY - 3 };
                bool flag = false;
                for (int i = LocX; i <= LocX + 3; i++)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s2.LocationXend = Pos[0];
                    s2.LocationYend = LocY;
                    enemyships.Add(s2);
                } else
                {
                    s2.LocationXend = LocX;
                    s2.LocationYend = Pos[1];
                    enemyships.Add(s2);
                }
            } else if (LocX + 3 > 10 && LocY + 3 > 10)
            {
                int[] Pos = { LocX - 3, LocY - 3 };
                bool flag = false;
                for (int i = LocX; i >= LocX - 3; i--)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s2.LocationXend = Pos[0];
                    s2.LocationXend = LocY;
                    enemyships.Add(s2);
                } else
                {
                    s2.LocationXend = LocX;
                    s2.LocationYend = Pos[1];
                    enemyships.Add(s2);
                }
            } else if (LocY - 3 < 1)
            {
                int[] Pos = { LocX - 3, LocX + 3, LocY + 3 };
                bool flag = false;
                for (int i = LocX; i >= LocX - 3; i--)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s2.LocationXend = Pos[0];
                    s2.LocationYend = LocY;
                    enemyships.Add(s2);
                } else
                {
                    flag = false;
                    for (int i = LocX; i <= LocX + 3; i++)
                    {
                        if (grid[((LocY - 1) * 10 + i) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s2.LocationXend = Pos[1];
                        s2.LocationYend = LocY;
                        enemyships.Add(s2);
                    } else
                    {
                        s2.LocationXend = LocX;
                        s2.LocationYend = Pos[2];
                        enemyships.Add(s2);
                    }
                }
            } else if (LocX - 3 < 1)
            {
                int[] Pos = { LocX + 3, LocY + 3, LocY - 3 };
                bool flag = false;
                for (int i = LocX; i <= LocX + 3; i++)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s2.LocationXend = Pos[0];
                    s2.LocationYend = LocY;
                    enemyships.Add(s2);
                }
                else
                {
                    flag = false;
                    for (int i = LocY; i >= LocY - 3; i--)
                    {
                        if (grid[((i - 1) * 10 + LocX) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s2.LocationXend = LocX;
                        s2.LocationYend = Pos[2];
                        enemyships.Add(s2);
                    } else
                    {
                        s2.LocationXend = LocX;
                        s2.LocationYend = Pos[1];
                        enemyships.Add(s2);
                    }
                }
            } else if (LocX + 3 > 10)
            {
                int[] Pos = { LocX - 3, LocY - 3, LocY + 3 };
                bool flag = false;
                for (int i = LocX; i >= LocX - 3; i--)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s2.LocationXend = Pos[0];
                    s2.LocationYend = LocY;
                    enemyships.Add(s2);
                }
                else
                {
                    flag = false;
                    for (int i = LocY; i >= LocY - 3; i--)
                    {
                        if (grid[((i - 1) * 10 + LocX) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s2.LocationXend = LocX;
                        s2.LocationYend = Pos[1];
                        enemyships.Add(s2);
                    }
                    else
                    {
                        s2.LocationXend = LocX;
                        s2.LocationYend = Pos[2];
                        enemyships.Add(s2);
                    }
                }
            } else if (LocY + 3 > 10)
            {
                int[] Pos = { LocX + 3, LocX - 3, LocY - 3 };
                bool flag = false;
                for (int i = LocX; i <= LocX + 3; i++)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s2.LocationXend = Pos[0];
                    s2.LocationYend = LocY;
                    enemyships.Add(s2);
                }
                else
                {
                    flag = false;
                    for (int i = LocX; i >= LocX - 3; i--)
                    {
                        if (grid[((i - 1) * 10 + LocX)-1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s2.LocationXend = Pos[1];
                        s2.LocationYend = LocY;
                        enemyships.Add(s2);
                    }
                    else
                    {
                        s2.LocationXend = LocX;
                        s2.LocationYend = Pos[2];
                        enemyships.Add(s2);
                    }
                }
            } else
            {
                int[] Pos = { LocX + 3, LocX - 3, LocY + 3, LocY - 3 };
                bool flag = false;
                for (int i = LocX; i <= LocX + 3; i++)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s2.LocationXend = Pos[0];
                    s2.LocationYend = LocY;
                    enemyships.Add(s2);
                }
                else
                {
                    flag = false;
                    for (int i = LocX; i >= LocX - 3; i--)
                    {
                        if (grid[((LocY - 1) * 10 + i) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s2.LocationXend = Pos[1];
                        s2.LocationYend = LocY;
                        enemyships.Add(s2);
                    } else
                    {
                        flag = false;
                        for (int i = LocY; i <= LocY + 3; i++)
                        {
                            if (grid[((i - 1) * 10 + LocX) - 1] == true)
                            {
                                flag = true;
                            }
                        }
                        if (flag == false)
                        {
                            s2.LocationXend = LocX;
                            s2.LocationYend = Pos[2];
                            enemyships.Add(s2);
                        } else
                        {
                            s2.LocationXend = LocX;
                            s2.LocationYend = Pos[3];
                            enemyships.Add(s2);
                        }
                    }
                }
            }
            if (s2.LocationXstart != s2.LocationXend)
            {
                s2.LocationYend = s2.LocationYstart;
            }

            if (s2.LocationXstart == s2.LocationXend)
            {
                if (s2.LocationYstart > s2.LocationYend)
                {
                    for (int i = s2.LocationYstart; i >= s2.LocationYend; i--)
                    {
                        grid[(i - 1) * 10 + s2.LocationXstart - 1] = true;
                    }
                }
                else if (s2.LocationYstart < s2.LocationYend)
                {
                    for (int i = s2.LocationYstart; i <= s2.LocationYend; i++)
                    {
                        grid[(i - 1) * 10 + s2.LocationXstart - 1] = true;
                    }
                }
            }
            else if (s2.LocationYstart == s2.LocationYend)
            {
                if (s2.LocationXstart > s2.LocationXend)
                {
                    for (int i = s2.LocationXstart; i >= s2.LocationXend; i--)
                    {
                        grid[(s2.LocationYstart - 1) * 10 + i - 1] = true;
                    }
                }
                else if (s2.LocationXstart < s2.LocationXend)
                {
                    for (int i = s2.LocationXstart; i <= s2.LocationXend; i++)
                    {
                        grid[(s2.LocationYstart - 1) * 10 + i - 1] = true;
                    }
                }
            }

            Ships s3 = new Ships();
            s3.Name = "Πολεμικό";
            s3.TileSize = 3;
            LocX = r.Next(1, 11);
            LocY = r.Next(1, 11);
            while (grid[((LocY - 1) * 10 + LocX) - 1] == true)
            {
                LocX = r.Next(1, 11);
                LocY = r.Next(1, 11);
            }
            s3.LocationXstart = LocX;
            s3.LocationYstart = LocY;
            if (LocX - 2 < 1 && LocY - 2 < 1)
            {
                int[] Pos = { LocX + 2, LocY + 2 };
                bool flag = false;
                for (int i = LocX; i <= LocX + 2; i++)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s3.LocationXend = Pos[0];
                    s3.LocationYend = LocY;
                    enemyships.Add(s3);
                }
                else
                {
                    s3.LocationXend = LocX;
                    s3.LocationYend = Pos[1];
                    enemyships.Add(s3);
                }
            }
            else if (LocX + 2 > 10 && LocY - 2 < 1)
            {
                int[] Pos = { LocX - 2, LocY + 2 };
                bool flag = false;
                for (int i = LocX; i >= LocX - 2; i--)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s3.LocationXend = Pos[0];
                    s3.LocationYend = LocY;
                    enemyships.Add(s3);
                }
                else
                {
                    s3.LocationXend = LocX;
                    s3.LocationYend = Pos[1];
                    enemyships.Add(s3);
                }
            }
            else if (LocX - 2 < 1 && LocY + 2 > 10)
            {
                int[] Pos = { LocX + 2, LocY - 2 };
                bool flag = false;
                for (int i = LocX; i <= LocX + 2; i++)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s3.LocationXend = Pos[0];
                    s3.LocationYend = LocY;
                    enemyships.Add(s3);
                }
                else
                {
                    s3.LocationXend = LocX;
                    s3.LocationYend = Pos[1];
                    enemyships.Add(s3);
                }
            }
            else if (LocX + 2 > 10 && LocY + 2 > 10)
            {
                int[] Pos = { LocX - 2, LocY - 2 };
                bool flag = false;
                for (int i = LocX; i >= LocX - 2; i--)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s3.LocationXend = Pos[0];
                    s3.LocationYend = LocY;
                    enemyships.Add(s3);
                }
                else
                {
                    s3.LocationXend = LocX;
                    s3.LocationYend = Pos[1];
                    enemyships.Add(s3);
                }
            }
            else if (LocX - 2 < 1)
            {
                int[] Pos = { LocX + 2, LocY + 2, LocY - 2 };
                bool flag = false;
                for (int i = LocX; i <= LocX + 2; i++)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s3.LocationXend = Pos[0];
                    s3.LocationYend = LocY;
                    enemyships.Add(s3);
                }
                else
                {
                    flag = false;
                    for (int i = LocY; i <= LocY + 2; i++)
                    {
                        if (grid[((i - 1) * 10 + LocX) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s3.LocationXend = LocX;
                        s3.LocationYend = Pos[1];
                        enemyships.Add(s3);
                    }
                    else
                    {
                        s3.LocationXend = LocX;
                        s3.LocationYend = Pos[2];
                        enemyships.Add(s3);
                    }
                }
            }
            else if (LocY - 2 < 1)
            {
                int[] Pos = { LocX + 2, LocX - 2, LocY + 2 };
                bool flag = false;
                for (int i = LocX; i <= LocX + 2; i++)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s3.LocationXend = Pos[0];
                    s3.LocationYend = LocY;
                    enemyships.Add(s3);
                }
                else
                {
                    flag = false;
                    for (int i = LocX; i >= LocX - 2; i--)
                    {
                        if (grid[((LocY - 1) * 10 + i) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s3.LocationXend = Pos[1];
                        s3.LocationYend = LocY;
                        enemyships.Add(s3);
                    }
                    else
                    {
                        s3.LocationXend = LocX;
                        s3.LocationYend = Pos[2];
                        enemyships.Add(s3);
                    }
                }
            }
            else if (LocX + 2 > 10)
            {
                int[] Pos = { LocX - 2, LocY + 2, LocY - 2 };
                bool flag = false;
                for (int i = LocX; i >= LocX - 2; i--)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s3.LocationXend = Pos[0];
                    s3.LocationXend = LocY;
                    enemyships.Add(s3);
                }
                else
                {
                    flag = false;
                    for (int i = LocY; i <= LocY + 2; i++)
                    {
                        if (grid[((i - 1) * 10 + LocX) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s3.LocationXend = LocX;
                        s3.LocationYend = Pos[1];
                        enemyships.Add(s3);
                    }
                    else
                    {
                        s3.LocationXend = LocX;
                        s3.LocationYend = Pos[2];
                        enemyships.Add(s3);
                    }
                }
            }
            else if (LocY + 2 > 10)
            {
                int[] Pos = { LocX + 2, LocX - 2, LocY - 2 };
                bool flag = false;
                for (int i = LocX; i <= LocX + 2; i++)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s3.LocationXend = Pos[0];
                    s3.LocationXend = LocY;
                    enemyships.Add(s3);
                }
                else
                {
                    flag = false;
                    for (int i = LocX; i >= LocX - 2; i++)
                    {
                        if (grid[((LocY - 1) * 10 + i) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s3.LocationXend = Pos[1];
                        s3.LocationYend = LocY;
                        enemyships.Add(s3);
                    }
                    else
                    {
                        s3.LocationXend = LocX;
                        s3.LocationYend = Pos[2];
                        enemyships.Add(s3);
                    }
                }
            }
            else
            {
                int[] Pos = { LocX + 2, LocX - 2, LocY + 2, LocY - 2 };
                bool flag = false;
                for (int i = LocX; i <= LocX + 2; i++)
                {
                    if (grid[((LocY - 1) * 10 + i) - 1] == true)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    s3.LocationXend = Pos[0];
                    s3.LocationYend = LocY;
                    enemyships.Add(s3);
                }
                else
                {
                    flag = false;
                    for (int i = LocX; i >= LocX - 2; i--)
                    {
                        if (grid[((LocY - 1) * 10 + i) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s3.LocationXend = Pos[1];
                        s3.LocationYend = LocY;
                        enemyships.Add(s3);
                    }
                    else
                    {
                        flag = false;
                        for (int i = LocY; i <= LocY + 2; i++)
                        {
                            if (grid[((i - 1) * 10 + LocX) - 1] == true)
                            {
                                flag = true;
                            }
                        }
                        if (flag == false)
                        {
                            s3.LocationXend = LocX;
                            s3.LocationYend = Pos[2];
                            enemyships.Add(s3);
                        }
                        else
                        {
                            s3.LocationXend = LocX;
                            s3.LocationYend = Pos[3];
                            enemyships.Add(s3);
                        }
                    }
                }
            }
            if (s3.LocationXstart != s3.LocationXend)
            {
                s3.LocationYend = s3.LocationYstart;
            }

            if (s3.LocationXstart == s3.LocationXend)
            {
                if (s3.LocationYstart > s3.LocationYend)
                {
                    for (int i = s3.LocationYstart; i >= s3.LocationYend; i--)
                    {
                        grid[(i - 1) * 10 + s3.LocationXstart - 1] = true;
                    }
                }
                else if (s3.LocationYstart < s3.LocationYend)
                {
                    for (int i = s3.LocationYstart; i <= s3.LocationYend; i++)
                    {
                        grid[(i - 1) * 10 + s3.LocationXstart - 1] = true;
                    }
                }
            }
            else if (s3.LocationYstart == s3.LocationYend)
            {
                if (s3.LocationXstart > s3.LocationXend)
                {
                    for (int i = s3.LocationXstart; i >= s3.LocationXend; i--)
                    {
                        grid[(s3.LocationYstart - 1) * 10 + i - 1] = true;
                    }
                }
                else if (s3.LocationXstart < s3.LocationXend)
                {
                    for (int i = s3.LocationXstart; i <= s3.LocationXend; i++)
                    {
                        grid[(s3.LocationYstart - 1) * 10 + i - 1] = true;
                    }
                }
            }


            Ships s4 = new Ships();
            s4.Name = "Υποβρύχιο";
            s4.TileSize = 2;
            while (enemyships.Count == 3)
            {
                LocX = r.Next(1, 11);
                LocY = r.Next(1, 11);
                while (grid[((LocY - 1) * 10 + LocX) - 1] == true)
                {
                    LocX = r.Next(1, 11);
                    LocY = r.Next(1, 11);
                }
                s4.LocationXstart = LocX;
                s4.LocationYstart = LocY;
                if (LocX == 1 && LocY == 1)
                {
                    int[] Pos = { LocX + 1, LocY + 1 };
                    bool flag = false;
                    for (int i = LocX; i <= LocX + 1; i++)
                    {
                        if (grid[((LocY - 1) * 10 + i) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s4.LocationXend = Pos[0];
                        s4.LocationYend = LocY;
                        enemyships.Add(s4);
                    }
                    else
                    {
                        s4.LocationXend = LocX;
                        s4.LocationYend = Pos[1];
                        enemyships.Add(s4);
                    }
                }
                else if (LocX == 10 && LocY == 1)
                {
                    int[] Pos = { LocX - 1, LocY + 1 };
                    bool flag = false;
                    for (int i = LocX; i >= LocX - 1; i--)
                    {
                        if (grid[((LocY - 1) * 10 + i) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s4.LocationXend = Pos[0];
                        s4.LocationYend = LocY;
                        enemyships.Add(s4);
                    }
                    else
                    {
                        s4.LocationXend = LocX;
                        s4.LocationYend = Pos[1];
                        enemyships.Add(s4);
                    }
                }
                else if (LocX == 1 && LocY == 10)
                {
                    int[] Pos = { LocX + 1, LocY - 1 };
                    bool flag = false;
                    for (int i = LocX; i <= LocX + 1; i++)
                    {
                        if (grid[((LocY - 1) * 10 + i) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s4.LocationXend = Pos[0];
                        s4.LocationYend = LocY;
                        enemyships.Add(s4);
                    }
                    else
                    {
                        s4.LocationXend = LocX;
                        s4.LocationYend = Pos[1];
                        enemyships.Add(s4);
                    }
                }else if (LocX == 10 && LocY == 10)
                {
                    int[] Pos = { LocX - 1, LocY - 1 };
                    bool flag = false;
                    for (int i = LocX; i >= LocX - 1; i--)
                    {
                        if (grid[((LocY-1)*10+i)-1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s4.LocationXend = Pos[0];
                        s4.LocationYend = LocY;
                        enemyships.Add(s4);
                    }
                    else
                    {
                        s4.LocationXend = LocX;
                        s4.LocationYend = Pos[1];
                        enemyships.Add(s4);
                    }
                }
                else if (LocX == 1)
                {
                    int[] Pos = { LocX + 1, LocY + 1, LocY - 1 };
                    bool flag = false;
                    for (int i = LocX; i <= LocX + 1; i++)
                    {
                        if (grid[((LocY - 1) * 10 + i) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s4.LocationXend = Pos[0];
                        s4.LocationXend = LocY;
                        enemyships.Add(s4);
                    }
                    else
                    {
                        flag = false;
                        for (int i = LocY; i <= LocY + 1;)
                        {
                            if (grid[((i - 1) * 10 + LocX) - 1] == true)
                            {
                                flag = true;
                            }
                        }
                        if (flag == false)
                        {
                            s4.LocationXend = LocX;
                            s4.LocationYend = Pos[1];
                            enemyships.Add(s4);
                        }
                        else
                        {
                            s4.LocationXend = LocX;
                            s4.LocationYend = Pos[2];
                            enemyships.Add(s4);
                        }
                    }
                }
                else if (LocY == 1)
                {
                    int[] Pos = { LocX + 1, LocX - 1, LocY + 1 };
                    bool flag = false;
                    for (int i = LocX; i <= LocX + 1; i++)
                    {
                        if (grid[((LocY - 1) * 10 + i) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s4.LocationXend = Pos[0];
                        s4.LocationYend = LocY;
                        enemyships.Add(s4);
                    }
                    else
                    {
                        flag = false;
                        for (int i = LocX; i >= LocX; i--)
                        {
                            if (grid[((LocY - 1) * 10 + i) - 1] == true)
                            {
                                flag = true;
                            }
                        }
                        if (flag == false)
                        {
                            s4.LocationXend = Pos[1];
                            s4.LocationYend = LocY;
                            enemyships.Add(s4);
                        }
                        else
                        {
                            s4.LocationXend = LocX;
                            s4.LocationYend = Pos[2];
                            enemyships.Add(s4);
                        }
                    }
                }
                else if (LocX == 10)
                {
                    int[] Pos = { LocX - 1, LocY + 1, LocY - 1 };
                    bool flag = false;
                    for (int i = LocX; i >= LocX - 1; i--)
                    {
                        if (grid[((LocY - 1) * 10 + i) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s4.LocationXend = Pos[0];
                        s4.LocationYend = LocY;
                        enemyships.Add(s4);
                    }
                    else
                    {
                        flag = false;
                        for (int i = LocY; i <= LocY + 1; i++)
                        {
                            if (grid[((i - 1) * 10 + LocX) - 1] == true)
                            {
                                flag = true;
                            }
                        }
                        if (flag == false)
                        {
                            s4.LocationXend = LocX;
                            s4.LocationYend = Pos[1];
                            enemyships.Add(s4);
                        }
                        else
                        {
                            s4.LocationXend = LocX;
                            s4.LocationYend = Pos[2];
                            enemyships.Add(s4);
                        }
                    }
                }
                else if (LocY == 10)
                {
                    int[] Pos = { LocX + 1, LocX - 1, LocY - 1 };
                    bool flag = false;
                    for (int i = LocX; i <= LocX + 1; i++)
                    {
                        if (grid[((LocY - 1) * 10 + i) - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s4.LocationXend = Pos[0];
                        s4.LocationYend = LocY;
                        enemyships.Add(s4);
                    }
                    else
                    {
                        flag = false;
                        for (int i = LocX; i >= LocX - 1; i--)
                        {
                            if (grid[((LocY - 1) * 10 + i) - 1] == true)
                            {
                                flag = true;
                            }
                        }
                        if (flag == false)
                        {
                            s4.LocationXend = Pos[1];
                            s4.LocationYend = LocY;
                            enemyships.Add(s4);
                        }
                        else
                        {
                            s4.LocationXend = LocX;
                            s4.LocationYend = Pos[2];
                        }
                    }
                }else
                {
                    int[] Pos = { LocX + 1, LocX - 1, LocY + 1, LocY - 1 };
                    bool flag = false;
                    for (int i = LocX; i <= LocX + 1; i++)
                    {
                        if (grid[(LocY - 1) * 10 + i - 1] == true)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        s4.LocationXend = Pos[0];
                        s4.LocationYend = LocY;
                        enemyships.Add(s4);
                    }else
                    {
                        flag = false;
                        for (int i = LocX; i>= LocX - 1; i--)
                        {
                            if(grid[(LocY - 1) * 10 + i - 1] == true)
                            {
                                flag = true;
                            }
                        }
                        if (flag == false)
                        {
                            s4.LocationXend = Pos[1];
                            s4.LocationYend = LocY;
                            enemyships.Add(s4);
                        }
                        else
                        {
                            flag = false;
                            for (int i = LocY; i <= LocY + 1; i++)
                            {
                                if (grid[(i-1)*10+LocX-1] == true)
                                {
                                    flag = true;
                                }
                            }
                            if (flag == false)
                            {
                                s4.LocationXend = LocX;
                                s4.LocationYend = Pos[2];
                                enemyships.Add(s4);
                            }else
                            {
                                s4.LocationXend = LocX;
                                s4.LocationYend = Pos[3];
                                enemyships.Add(s4);
                            }
                        }
                    }
                }
                if (s4.LocationXstart != s4.LocationXend)
                {
                    s4.LocationYend = s4.LocationYstart;
                }


                if (s4.LocationXstart == s4.LocationXend)
                {
                    if (s4.LocationYstart > s4.LocationYend)
                    {
                        for (int i = s4.LocationYstart; i >= s4.LocationYend; i--)
                        {
                            grid[(i - 1) * 10 + s4.LocationXstart - 1] = true;
                        }
                    }
                    else if (s4.LocationYstart < s4.LocationYend)
                    {
                        for (int i = s4.LocationYstart; i <= s4.LocationYend; i++)
                        {
                            grid[(i - 1) * 10 + s4.LocationXstart - 1] = true;
                        }
                    }
                }
                else if (s4.LocationYstart == s4.LocationYend)
                {
                    if (s4.LocationXstart > s4.LocationXend)
                    {
                        for (int i = s4.LocationXstart; i >= s4.LocationXend; i--)
                        {
                            grid[(s4.LocationYstart - 1) * 10 + i - 1] = true;
                        }
                    }
                    else
                    {
                        for (int i = s4.LocationXstart; i <= s4.LocationXend; i++)
                        {
                            grid[(s4.LocationYstart - 1) * 10 + i - 1] = true;
                        }
                    }
                }
            }

        }

        public void Hit(bool[] EnemyGrid,List<Ships> EnemyShips, int x, int y)
        {
            if (EnemyGrid[((y - 1) * 10 + x) - 1] == false)
            {
                foreach (Ships s in EnemyShips)
                {
                    if (s.LocationXstart == s.LocationXend)
                    {
                        if (s.LocationYstart < s.LocationYend)
                        {
                            for (int i = s.LocationYstart; i <= s.LocationYend; i++)
                            {
                                if (i == y && s.LocationXstart == x)
                                {
                                    s.TileSize = s.TileSize - 1;                                  
                                }
                            }
                        }
                        else if (s.LocationYstart > s.LocationYend)
                        {
                            for (int i = s.LocationYstart; i >= s.LocationYend; i--)
                            {
                                if (i == y && s.LocationXstart == x)
                                {
                                    s.TileSize = s.TileSize - 1;                                                                   
                                }
                            }
                        }
                    }
                    else if (s.LocationYstart == s.LocationYend)
                    {
                        if (s.LocationXstart < s.LocationXend)
                        {
                            for (int i = s.LocationXstart; i <= s.LocationXend; i++)
                            {
                                if (s.LocationYstart == y && i == x)
                                {
                                    s.TileSize = s.TileSize - 1;
                                    
                                }
                            }
                        }
                        else if (s.LocationXstart > s.LocationXend)
                        {
                            for (int i = s.LocationXstart; i >= s.LocationXend; i--)
                            {
                                if (s.LocationYstart == y && i == x)
                                {
                                    s.TileSize = s.TileSize - 1;
                                    
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}