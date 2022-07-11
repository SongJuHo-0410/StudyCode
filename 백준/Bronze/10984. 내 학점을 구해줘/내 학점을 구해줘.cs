int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double count = 0;
                double total = 0;
                int c = int.Parse(Console.ReadLine());
                for (int j = 0; j < c; j++)
                {
                    string[] s = Console.ReadLine().Split();
                    double a = double.Parse(s[0]);
                    double b = double.Parse(s[1]);
                    count += a;
                    total += a * b;
                }
                Console.WriteLine("{0:0} {1:0.0}",count,total / count);
            }