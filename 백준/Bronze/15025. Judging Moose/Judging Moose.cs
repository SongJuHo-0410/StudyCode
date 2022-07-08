string[] input = Console.ReadLine().Split();
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            int max = Math.Max(n1, n2);

            if (n1 == 0 && n2 == 0) Console.WriteLine("Not a moose");
            else if (n1 == n2) Console.WriteLine("Even " + n1 * 2);
            else if (n1 != n2) Console.WriteLine("Odd " + max * 2);