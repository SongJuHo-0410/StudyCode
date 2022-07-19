int n = int.Parse(Console.ReadLine());

            int ball = 1;
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                if (a == ball) ball = b;
                else if (b == ball) ball = a;
            }
            
            Console.WriteLine(ball);