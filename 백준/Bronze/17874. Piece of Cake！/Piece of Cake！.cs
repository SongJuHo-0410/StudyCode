string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int h = int.Parse(s[1]);
            int v = int.Parse(s[2]);

            int hMax = Math.Max(h,n - h);
            int vMax = Math.Max(v,n - v);

            Console.WriteLine(hMax * vMax * 4);