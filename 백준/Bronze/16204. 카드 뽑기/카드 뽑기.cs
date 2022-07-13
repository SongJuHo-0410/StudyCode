string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]); //전체
            int m = int.Parse(s[1]); //앞면 0
            int k = int.Parse(s[2]); //뒷면 0

            int fo = n - m; //앞면 x
            int bo = n - k; //뒷면 x

            int fs = Math.Min(m, k);
            int bs = Math.Min(fo,bo);
            Console.WriteLine(fs + bs);