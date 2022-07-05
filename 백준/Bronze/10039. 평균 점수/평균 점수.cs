            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int[] n = { n1, n2, n3, n4, n5 };
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                if (n[i] < 40)
                {
                    n[i] = 40;
                }
                total += n[i];
            }

            Console.WriteLine(total / 5);
