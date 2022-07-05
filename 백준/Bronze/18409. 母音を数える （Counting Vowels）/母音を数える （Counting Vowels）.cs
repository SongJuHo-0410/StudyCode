int num = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int cnt = 0;
            for (int i = 0; i < num; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' )
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);