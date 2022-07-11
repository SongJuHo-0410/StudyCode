string[] input = Console.ReadLine().Split();
            double pq1 = double.Parse(input[0]) / double.Parse(input[1]);
            double pq2 = double.Parse(input[2]) / double.Parse(input[3]);
            double result = double.Parse(input[0]) / double.Parse(input[1]) * double.Parse(input[2]) / double.Parse(input[3]) / 2;
            if (result == (long)result) Console.WriteLine(1);
            else if (result != (long)result) Console.WriteLine(0);