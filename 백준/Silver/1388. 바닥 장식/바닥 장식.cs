string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            string[,] room = new string[n,m];
            int total = 0;
            int check = 0;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < line.Length; j++)
                {
                    room[i,j] = line[j].ToString();
                }
            }           
            
            for (int c = 0; c < n; c++)
            {
                check = 0;
                    for (int cc = 0; cc < m; cc++)
                    {
                        if (room[c, cc] == "-")
                        {
                            check++;
                            if (check == 1) total++;
                        }
                        else check = 0;
                    }
            }

            for (int c = 0; c < m; c++)
            {
                check = 0;
                for (int cc = 0; cc < n; cc++)
                    {
                        if (room[cc, c] == "|")
                        {
                            check++;
                            if (check == 1) total++;
                        }
                        else check = 0;
                    }
            }
            Console.WriteLine(total);