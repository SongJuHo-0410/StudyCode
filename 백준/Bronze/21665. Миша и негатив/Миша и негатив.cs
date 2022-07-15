string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            string[,] check = new string[n,m];
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                string a = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    check[i, j] = a[j].ToString();
                }
            }
            string space = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                string b = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    if (b[j].ToString() == check[i, j]) cnt++;
                }
            }
            Console.WriteLine(cnt);