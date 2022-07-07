string[] num = Console.ReadLine().Split();
            for (int k = 0; k < int.Parse(num[0]); k++)
            {
                string input = Console.ReadLine();
                for (int i = int.Parse(num[1]) -1; i >= 0; i--)
                {
                    Console.Write(input[i]);
                }
                Console.WriteLine();
            }