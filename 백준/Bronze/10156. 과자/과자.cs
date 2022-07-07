string[] input = Console.ReadLine().Split();
            int k = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int m = int.Parse(input[2]);
            int total = k * n;

            if (total < m || total == m) Console.WriteLine(0);
            else if(total > m) Console.WriteLine(total - m);