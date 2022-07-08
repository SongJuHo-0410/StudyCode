int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());

            int n1 = (a2 * 2) + (a3 * 4);
            int n2 = (a1 * 2) + (a3 * 2);
            int n3 = (a1 * 4) + (a2 * 2);

            int min = Math.Min(n1,n2);
            min = Math.Min(min,n3);

            Console.WriteLine(min);