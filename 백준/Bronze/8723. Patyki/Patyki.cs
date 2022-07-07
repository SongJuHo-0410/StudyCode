string[] input = Console.ReadLine().Split();
            double a = double.Parse(input[0]); // 3
            double b = double.Parse(input[1]); // 4
            double c = double.Parse(input[2]); // 5
            double result = 0;
            double max = Math.Max(a,b);
            max = Math.Max(max,c);
            if (max == a) result = Math.Pow(b, 2) + Math.Pow(c, 2);
            else if (max == b) result = Math.Pow(a, 2) + Math.Pow(c, 2);
            else if (max == c) result = Math.Pow(a, 2) + Math.Pow(b, 2);

            if (a == b && b == c) Console.WriteLine(2);
            else if (Math.Pow(max, 2) == result) Console.WriteLine(1);
            else Console.WriteLine(0);