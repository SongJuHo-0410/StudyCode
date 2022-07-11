while(true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) break;
                string[] s = Console.ReadLine().Split();
                int x = 0, y = 0;
                for (int i = 0; i < n; i++)
                {
                    if (int.Parse(s[i]) == 0) x++;
                    else y++;
                }
                Console.WriteLine("Mary won " + x + " times and John won " + y + " times");
            }