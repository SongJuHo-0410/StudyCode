int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                long a = int.Parse(s[0]);
                long b = int.Parse(s[1]);
                double result = Math.Pow(a, 2) / Math.Pow(b, 2);
                Console.WriteLine(result);
            }