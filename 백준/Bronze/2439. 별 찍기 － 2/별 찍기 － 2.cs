            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = num-1; i < j; j--)
                {
                    Console.Write(" ");
                }
                for (int z = 0; z <= i; z++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
