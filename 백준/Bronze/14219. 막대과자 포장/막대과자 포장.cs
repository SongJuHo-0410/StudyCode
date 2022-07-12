string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            if ((a * b) % 3 == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");