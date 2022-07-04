            for (int i = 0; i < 2; i++)
            {
                string[] input = Console.ReadLine().Split();
                int n1 = int.Parse(input[0]) * 6;
                int n2 = int.Parse(input[1]) * 3;
                int n3 = int.Parse(input[2]) * 2;
                int n4 = int.Parse(input[3]) * 1;
                int n5 = int.Parse(input[4]) * 2;
                int result = n1 + n2 + n3 + n4 + n5;
                Console.WriteLine(result);
            }