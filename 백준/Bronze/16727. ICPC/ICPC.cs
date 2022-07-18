string[] ps1 = Console.ReadLine().Split();
            int p1 = int.Parse(ps1[0]);
            int s1 = int.Parse(ps1[1]);

            string[] sp2 = Console.ReadLine().Split();
            int s2 = int.Parse(sp2[0]);
            int p2 = int.Parse(sp2[1]);

            int pMax = p1 + p2;
            int sMax = s1 + s2;

            int a = Math.Max(p1,p2);
            int b = Math.Max(s1,s2);

            if (pMax > sMax) Console.WriteLine("Persepolis");
            else if (pMax < sMax) Console.WriteLine("Esteghlal");
            else if(pMax == sMax)
            {
                if (s1 < p2) Console.WriteLine("Persepolis");
                else if (s1 > p2) Console.WriteLine("Esteghlal");
                else if (s1 == p2) Console.WriteLine("Penalty");
            }