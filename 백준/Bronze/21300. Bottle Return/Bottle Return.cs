            string[] input = Console.ReadLine().Split();
            int result = 0;
            for (int i = 0; i < 6; i++)
            {
                result += int.Parse(input[i]) * 5;
            }
            Console.WriteLine(result);