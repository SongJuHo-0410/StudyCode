            while(true)
            {
                int cnt = 0;
                string input = Console.ReadLine();
                if (input == "#") break;
                input = input.ToLower();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                    {
                        cnt++;
                    }
                }
                Console.WriteLine(cnt);
            }