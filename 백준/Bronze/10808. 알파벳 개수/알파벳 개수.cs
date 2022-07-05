            string input = Console.ReadLine();
            int[] check = new int[26];

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 97; j < 123; j++)
                {
                    if (input[i] == j)
                    {
                        check[j - 97]++;
                        break;
                    }
                }
            }

            for (int i = 0; i < 26; i++)
            {
                Console.Write(check[i] + " ");
            }