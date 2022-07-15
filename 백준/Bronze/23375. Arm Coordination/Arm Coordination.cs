string[] s = Console.ReadLine().Split();
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1}", (x - r), (y + r));
            Console.WriteLine("{0} {1}", (x + r), (y + r));
            Console.WriteLine("{0} {1}", (x + r), (y - r));
            Console.WriteLine("{0} {1}", (x - r), (y - r));