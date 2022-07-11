while(true)
            {
                int n = int.Parse(Console.ReadLine());
                int total = 0;
                if (n == 0) break;
                for (int i = 1; i <= n; i++)
                {
                    total += (int)Math.Pow(i, 2);
                }
                Console.WriteLine(total);
            }