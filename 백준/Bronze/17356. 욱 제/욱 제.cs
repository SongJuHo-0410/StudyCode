string[] input = Console.ReadLine().Split();
            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            double m = (b - a) / 400;
            
            double result = 1 / (1 + Math.Pow(10,m));
            Console.WriteLine(result);