int n = int.Parse(Console.ReadLine());

            if (n % 8 == 1) Console.WriteLine(1);
            else if (n % 8 == 0 || n % 8 == 2) Console.WriteLine(2) ;
            else if (n % 8 == 7 || n % 8 == 3) Console.WriteLine(3) ;
            else if (n % 8 == 6 || n % 8 == 4) Console.WriteLine(4) ;
            else if (n % 8 == 5) Console.WriteLine(5);