string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);
            bool check = true;
            
            for (int i = 0; i < m; i++)
                {
                    string[] t = Console.ReadLine().Split();
                    for (int j = 0; j < t.Length; j++)
                    {
                        if (n >= Math.Abs(int.Parse(t[j]))) check = true;
                        else check = false;
                    }
                }
            if (m < 8) check = false;
            if (check == true) Console.WriteLine("satisfactory");
            else Console.WriteLine("unsatisfactory");