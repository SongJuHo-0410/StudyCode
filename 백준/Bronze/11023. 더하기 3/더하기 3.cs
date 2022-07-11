int total = 0;
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < s.Length; i++)
            {
                total += int.Parse(s[i]);
            }
            Console.WriteLine(total);