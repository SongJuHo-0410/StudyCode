string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            int w = int.Parse(input[1]);
            int h = int.Parse(input[2]);
            int l = int.Parse(input[3]);
            w = w / l;
            h = h / l;
            int result = w * h;
            if (result > n - 1) result = n;
            Console.WriteLine(result);