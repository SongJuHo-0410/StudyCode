int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                decimal a = decimal.Parse(s[0]);
                decimal b = decimal.Parse(s[1]);
                Console.WriteLine(Math.Ceiling(a / b));
            }
            