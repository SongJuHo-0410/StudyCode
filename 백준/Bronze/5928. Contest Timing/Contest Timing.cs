string[] input = Console.ReadLine().Split();
            int d = int.Parse(input[0]);
            int h = int.Parse(input[1]);
            int m = int.Parse(input[2]);

            int num = (11 * 24 * 60) + (11 * 60) + 11;
            int result = (d * 24 * 60) + (h * 60) + m - num;
            if (result < 0) Console.WriteLine(-1);
            else Console.WriteLine(result);