int n = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                total += b % a;
            }
            Console.WriteLine(total);