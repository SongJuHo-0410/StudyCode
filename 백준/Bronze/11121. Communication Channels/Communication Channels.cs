int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                if (s[0] == s[1]) Console.WriteLine("OK");
                else Console.WriteLine("ERROR");
            }