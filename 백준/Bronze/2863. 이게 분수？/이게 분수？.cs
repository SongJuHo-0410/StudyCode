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

            string[] ab = Console.ReadLine().Split();
            string[] cd = Console.ReadLine().Split();
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            int c = int.Parse(cd[0]);
            int d = int.Parse(cd[1]);

            int res1 = a / c + b / d;
            int res2 = c / d + a / b;
            int res3 = d / b + c / a;
            int res4 = b / a + d / c;
            int[] res = { res1, res2, res3, res4 };
            int max = res1;
            int ans = 0;
            for (int i = 0; i < 4; i++)
            {
                if (max <= res[i])
                {
                    max = res[i];
                    ans = i;
                }
            }
            Console.WriteLine(ans);

        }
    }
}
