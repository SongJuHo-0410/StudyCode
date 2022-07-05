string[] input = Console.ReadLine().Split();
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            int max = Math.Max(n1 + n2,n1 - n2);
            int min = Math.Min(n1 + n2,n1 - n2);
            Console.WriteLine(max);
            Console.WriteLine(min);