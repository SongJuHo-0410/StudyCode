int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                Console.WriteLine("Case " + "{0}" + ": " + "{1}",i+1,a+b);
            }