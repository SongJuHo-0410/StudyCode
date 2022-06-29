            int setNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < setNum; i++)
            {
                string[] input = Console.ReadLine().Split();
                int count = int.Parse(input[0]);
                string s = input[1];
                for (int j = 0; j < s.Length; j++)
                {
                    for (int k = 0; k < count; k++)
                    {
                        Console.Write(s[j]);
                    }
                }
                Console.WriteLine();
            }