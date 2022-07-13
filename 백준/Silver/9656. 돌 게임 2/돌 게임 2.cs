int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0 || n % 4 == 0 || n % 6 == 0) Console.WriteLine("SK");
            else if (n % 1 == 0 || n % 3 == 0 || n % 5 == 0) Console.WriteLine("CY");
