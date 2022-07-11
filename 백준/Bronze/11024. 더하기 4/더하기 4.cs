int m = int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                int total = 0;
                string[] s = Console.ReadLine().Split();
                for (int i = 0; i < s.Length; i++)
                {
                    total += int.Parse(s[i]);
                }
                Console.WriteLine(total);
            }