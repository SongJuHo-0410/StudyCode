using System;
using System.Threading;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] d1 = Console.ReadLine().Split(":");
            int h1 = int.Parse(d1[0]);
            int m1 = int.Parse(d1[1]);
            int s1 = int.Parse(d1[2]);
            
            string[] d2 = Console.ReadLine().Split(":");
            int h2 = int.Parse(d2[0]);
            int m2 = int.Parse(d2[1]);
            int s2 = int.Parse(d2[2]);

            int rh = 0, rm = 0, rs = 0;

            TimeSpan ts;
            if(h1 == h2 && m1 == m2 && s1 == s2)
            {

                Console.WriteLine("24:00:00");

            }
            else
            {
                if (s2 < s1)
                {
                    m2--;
                    s2 += 60;
                }
                if (m2 < m1)
                {
                    h2--;
                    m2 += 60;
                }
                if (h2 < h1)
                {
                    h2 += 24;
                } 

                rs = s2 - s1;
                rm = m2 - m1;
                rh = h2 - h1;

                ts = new TimeSpan(rh, rm, rs);
                Console.WriteLine(ts.ToString());
            }

            

        }
    }
}
