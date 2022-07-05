            string[] input = Console.ReadLine().Split();

            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            int n3 = 0;
            int max = Math.Max(n1, n2);
            if (n1 == n2) n3 = n1;
            else if (max == n1) n3 = n1;
            else if (max == n2) n3 = n2;
            Console.Write(n3);