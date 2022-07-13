string[] s = Console.ReadLine().Split();
            int cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (int.Parse(s[i]) > 0) cnt++;
            }
            Console.WriteLine(cnt);