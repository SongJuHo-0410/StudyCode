string[] p1 = Console.ReadLine().Split();
            string[] p2 = Console.ReadLine().Split();

            int p1a = int.Parse(p1[0]);
            int p1h = int.Parse(p1[1]);
            int p2a = int.Parse(p2[0]);
            int p2h = int.Parse(p2[1]);

            while(true)
            {
                if (p1h <= 0 || p2h <= 0) break;
                p1h -= p2a;
                p2h -= p1a;
            }
            if (p2h <= 0 && p1h <= 0) Console.WriteLine("DRAW");
            else if (p2h <= 0) Console.WriteLine("PLAYER A");
            else if (p1h <= 0) Console.WriteLine("PLAYER B");