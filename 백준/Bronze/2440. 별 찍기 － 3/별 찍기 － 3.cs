            int num = int.Parse(Console.ReadLine());
            for (int j = 0; j < num; j++)
            {
                for (int i = num; i > j; i--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            