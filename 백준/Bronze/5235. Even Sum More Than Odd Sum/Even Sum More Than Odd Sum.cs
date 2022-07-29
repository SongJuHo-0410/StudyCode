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
                long even = 0;
                long odd = 0;
                string[] s = Console.ReadLine().Split();

                for (int j = 1; j <= int.Parse(s[0]); j++)
                {
                    long num = long.Parse(s[j]);
                    if (num % 2 == 0) even += num;
                    else if (num % 2 == 1) odd += num;
                }

                if (odd < even) Console.WriteLine("EVEN");
                else if (odd > even) Console.WriteLine("ODD");
                else if (odd == even) Console.WriteLine("TIE");
            }

            
            
            
        }
    }
}
