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
            for (int k = 0; k < n; k++)
            {
                for (int i = 1; i <= k; i++)
                {
                    Console.Write(" ");
                }
                for (int j = n * 2 - 1; j > k * 2; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int k = 0; k < n - 1; k++)
            {
                for (int i = n - 2; i > k; i--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= (k + 1) * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
