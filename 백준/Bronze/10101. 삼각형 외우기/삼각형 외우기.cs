int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;

            if(sum == 180)
            {
                if (a == b && b == c && a == c) Console.WriteLine("Equilateral");
                else if (a == b || b == c || a == c) Console.WriteLine("Isosceles");
                else Console.WriteLine("Scalene");
            }
            else Console.WriteLine("Error");