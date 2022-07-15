 string[] s = Console.ReadLine().Split();
            int x = int.Parse(s[0]);
            int l = int.Parse(s[1]);
            int r = int.Parse(s[2]);
            if (l <= x && x <= r) Console.WriteLine(x);
            else if(l > x) Console.WriteLine(l);
            else if(r < x) Console.WriteLine(r);