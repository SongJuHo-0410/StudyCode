            int l = int.Parse(Console.ReadLine());
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            double d = int.Parse(Console.ReadLine());

            double ac = a / c;
            double bd = b / d;

            double max = Math.Max(ac, bd);

            Console.WriteLine((int)(l - max));