string[] s = Console.ReadLine().Split();
            int c = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            int p = int.Parse(s[2]);
            double total = 0;
            for (int i = 0; i <= c; i++)
            {
                total += (k * i) + (p * Math.Pow(i,2));
            }
            Console.WriteLine(total);