while(true)
            {
                string[] s = Console.ReadLine().Split(' ');
                int m = int.Parse(s[0]);
                int n = int.Parse(s[1]);
                if (m == 0 && n == 0) break;
                Console.WriteLine(m + n);
            }