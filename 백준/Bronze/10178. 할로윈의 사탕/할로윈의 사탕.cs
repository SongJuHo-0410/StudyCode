int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                int div = a / b;
                int left = a % b;
                Console.WriteLine("You get {0} piece(s) and your dad gets {1} piece(s).",div,left);
            }