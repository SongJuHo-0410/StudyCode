string[] input = Console.ReadLine().Split();

            double a1 = double.Parse(input[0]);
            double n1 = double.Parse(input[1]);

            double ar = a1 / double.Parse(input[2]);
            double nr = n1 / double.Parse(input[2]);
            if (ar > (int)(ar))
            {
                ar = (int)(ar + 1);
            }
            if (nr > (int)(nr))
            {
                nr = (int)(nr + 1);
            }

            Console.WriteLine((ar * nr));