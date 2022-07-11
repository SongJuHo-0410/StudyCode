int cnt = 0;
            while(true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                {
                    break;
                }
                cnt++;
            }
            Console.WriteLine(cnt);