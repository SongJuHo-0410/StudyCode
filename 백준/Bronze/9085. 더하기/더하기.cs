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
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                    string[] s = Console.ReadLine().Split();
                    int total = 0;
                    for (int k = 0; k < n; k++)
                    {
                        total += int.Parse(s[k]);
                    }
                Console.WriteLine(total);
            }
            

        }
    }
}
