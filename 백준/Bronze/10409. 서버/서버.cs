string[] s = Console.ReadLine().Split();
            int total = 0;
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            string[] s2 = Console.ReadLine().Split();
            int cnt = 0;
            for (int i = 0; i < a; i++)
            {
                total += int.Parse(s2[i]);
                if (total > b) break;
                cnt++;
            }
            Console.WriteLine(cnt);