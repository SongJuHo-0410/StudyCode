            string[] input = Console.ReadLine().Split();
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            int n3 = int.Parse(input[2]);
            int max = n1;
            int min = n1;
            int mid = n1;
            max = Math.Max(max, n2);
            max = Math.Max(max, n3);
            min = Math.Min(min, n2);
            min = Math.Min(min, n3);

            if (max == n1 && min == n2)
                mid = n3;
            else if (max == n1 && min == n3)
                mid = n2;
            else if (max == n2 && min == n1)
                mid = n3;
            else if (max == n2 && min == n3)
                mid = n1;
            else if (max == n3 && min == n1)
                mid = n2;
            else if (max == n3 && min == n2)
                mid = n1;


            Console.WriteLine(min + " " + mid + " " + max);