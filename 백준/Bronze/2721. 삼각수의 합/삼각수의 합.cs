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
            int T(int n)
            {
                return n = n * (n + 1) / 2;
            }

            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int total = 0;
                int n = int.Parse(Console.ReadLine());
                for (int j = 1; j <= n; j++)
                {
                    total += j * T(j + 1);    
                }
                Console.WriteLine(total);
            }
            

            
            
        }
    }
}
