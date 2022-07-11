int p1 = 100, p2 = 100;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                if (a > b) p2 -= a;
                else if(b > a) p1 -= b;
            }
            Console.WriteLine(p1);
            Console.WriteLine(p2);