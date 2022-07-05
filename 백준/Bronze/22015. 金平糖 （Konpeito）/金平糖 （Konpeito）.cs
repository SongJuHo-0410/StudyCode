string[] input = Console.ReadLine().Split();
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            int n3 = int.Parse(input[2]);
            int max = Math.Max(n1, n2);
            max = Math.Max(max, n3);

            int total = (max - n1) + (max - n2) + (max - n3);
            Console.WriteLine(total);