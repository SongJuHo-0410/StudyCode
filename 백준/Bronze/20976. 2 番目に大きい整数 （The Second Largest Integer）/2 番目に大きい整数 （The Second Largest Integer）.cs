string[] input = Console.ReadLine().Split();

            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            int n3 = int.Parse(input[2]);
            int mid = 0;

            if ((n2 - 1 < n1 && n1 - 1 < n3) || (n3 - 1 < n1 && n1 - 1 < n2)) mid = n1;
            else if((n1 - 1 < n2 && n2 - 1 < n3) || (n3 - 1 < n2 && n2 - 1 < n1)) mid = n2;
            else if((n1 - 1 < n3 && n3 - 1 < n2) || (n2 - 1 < n3 && n3 - 1 < n1)) mid = n3;

            Console.WriteLine(mid);