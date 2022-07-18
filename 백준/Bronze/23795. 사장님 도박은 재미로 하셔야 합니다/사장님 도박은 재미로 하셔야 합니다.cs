int total = 0;
            while(true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == -1) break;
                total += n;
            }
            Console.WriteLine(total);