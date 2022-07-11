int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double p = double.Parse(Console.ReadLine());
                double result = p * 0.8;
                Console.WriteLine("${0:0.00}",Math.Round(result,2));
            }