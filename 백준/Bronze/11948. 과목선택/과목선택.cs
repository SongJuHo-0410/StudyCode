            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int n6 = int.Parse(Console.ReadLine());

            int fMin = Math.Min(n1,n2);
            fMin = Math.Min(fMin,n3);
            fMin = Math.Min(fMin,n4);
            int sMax = Math.Max(n5, n6);

            Console.WriteLine(n1+n2+n3+n4-fMin+sMax);