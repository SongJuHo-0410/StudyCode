int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(s[i]) != i+1) cnt++;
            }
            Console.WriteLine(cnt);