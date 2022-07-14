int n = int.Parse(Console.ReadLine());
            double total = 0; 
            for (int i = 1; i <= n; i++)
            {
                total += Math.Pow(i,3);
            }
            Console.WriteLine(total);