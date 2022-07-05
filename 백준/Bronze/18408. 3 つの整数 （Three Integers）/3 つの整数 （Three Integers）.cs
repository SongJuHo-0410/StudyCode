string[] input = Console.ReadLine().Split();
            int oCnt = 0;
            int sCnt = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "1") oCnt++;
                else if (input[i] == "2") sCnt++;
            }
            int max = Math.Max(oCnt,sCnt);
            if (max == oCnt) Console.WriteLine(1);
            else Console.WriteLine(2);