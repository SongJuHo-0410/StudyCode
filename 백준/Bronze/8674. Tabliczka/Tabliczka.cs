string[] input = Console.ReadLine().Split();
            double n1 = double.Parse(input[0]);
            double n2 = double.Parse(input[1]);

            //Console.WriteLine(n1 % 2);
            if (n1 % 2 == 0 || n2 % 2 == 0) Console.WriteLine(0);
            else if(n1 % 2 != 0 && n2 % 2 != 0) Console.WriteLine(Math.Min(n1,n2));
           