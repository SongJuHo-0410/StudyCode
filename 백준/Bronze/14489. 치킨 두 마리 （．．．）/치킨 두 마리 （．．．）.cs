string[] input = Console.ReadLine().Split();
            int cost = 2 * int.Parse(Console.ReadLine());

            int all = int.Parse(input[0]) + int.Parse(input[1]);

            if (all > cost || all == cost) Console.WriteLine(all - cost);
            else Console.WriteLine(all);