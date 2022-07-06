string[] input = Console.ReadLine().Split();
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            int dd = (n1 - n2) / 2;
            if (n2 > n1 || (n1 -n2) % 2 != 0) Console.WriteLine(-1);
            else
            {
                Console.WriteLine((dd + n2) + " " + dd);
            }