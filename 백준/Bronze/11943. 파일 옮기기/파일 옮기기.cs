string[] basket1 = Console.ReadLine().Split();
            string[] basket2 = Console.ReadLine().Split();

            int a1 = int.Parse(basket1[0]);
            int b1 = int.Parse(basket1[1]);
            int a2 = int.Parse(basket2[0]);
            int b2 = int.Parse(basket2[1]);

            int a1b2 = a1 + b2;
            int b2a1 = a2 + b1;

            Console.WriteLine(Math.Min(a1b2,b2a1));