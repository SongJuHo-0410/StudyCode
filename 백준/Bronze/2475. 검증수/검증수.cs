            string[] input = Console.ReadLine().Split();
            double result = 0;
            for (int i = 0; i < 5; i++)
            {
                result += Math.Pow(int.Parse(input[i]),2);
            }
            Console.WriteLine(result % 10);
