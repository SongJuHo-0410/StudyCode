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
            int[] res = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int total = 0;
                string[] s = Console.ReadLine().Split();
                for (int j = 0; j < 4; j++)
                {
                    total += int.Parse(s[j]);
                }
                res[i] = total;
            }

            int max = res[0];
            int check = 0;
            for (int i = 0; i < 5; i++)
            {
                if (max < res[i])
                {
                    check = i;
                    max = res[i];
                }
            }
            Console.WriteLine("{0} {1}",check + 1,max);

        }
    }
}
