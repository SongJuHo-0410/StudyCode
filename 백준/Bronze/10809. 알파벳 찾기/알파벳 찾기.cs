            String input = Console.ReadLine();
            for (int i = 97; i < 123; i++)
            {
                int num = -1;
                for (int j = 0; j < input.Length; j++)
                {
                    if(i == input[j])
                    {
                        num = j;
                        break;
                    }
;
                }
                Console.WriteLine(num);
            }
