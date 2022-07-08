string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int w = int.Parse(input[2]);
            int h = int.Parse(input[3]);

            int hy = h - y;
            int wx = w - x;
            int min = x;
            int[] n = { x, y, hy, wx };
            for (int i = 0; i < 4; i++)
            {
                if (n[i] < min) min = n[i];
            }
            Console.WriteLine(min);