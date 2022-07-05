int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] num = Console.ReadLine().Split();
                Console.WriteLine(int.Parse(num[0]) + int.Parse(num[1]));
            }