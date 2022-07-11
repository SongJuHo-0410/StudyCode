int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int price = int.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                for (int j = 0; j < count; j++)
                {
                    string[] input = Console.ReadLine().Split();
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    price += a * b;
                }
                Console.WriteLine(price);
            }
            