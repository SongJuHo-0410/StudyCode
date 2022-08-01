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
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int gTotal = 0;
                int sTotal = 0;
                string[] g = Console.ReadLine().Split(' ');
                int[] gNum = { 1, 2, 3, 3, 4, 10 };
                string[] s = Console.ReadLine().Split(' ');
                int[] sNum = { 1, 2, 2, 2, 3, 5, 10 };

                for (int j = 0; j < g.Length; j++)
                {
                    gTotal += int.Parse(g[j]) * gNum[j];
                }
                for (int j = 0; j < s.Length; j++)
                {
                    sTotal += int.Parse(s[j]) * sNum[j];
                }

                if (gTotal > sTotal) Console.WriteLine("Battle {0}: Good triumphs over Evil",i + 1);
                else if (gTotal < sTotal) Console.WriteLine("Battle {0}: Evil eradicates all trace of Good",i + 1);
                else Console.WriteLine("Battle {0}: No victor on this battle field",i + 1);
            }

        }
    }
}
