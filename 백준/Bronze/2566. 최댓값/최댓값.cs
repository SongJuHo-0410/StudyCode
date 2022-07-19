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
            int[,] n = new int[9,9];
            int max = 0;
            for (int i = 0; i < 9; i++)
            {
                string[] s = Console.ReadLine().Split();
                for (int j = 0; j < 9; j++)
                {
                    n[i, j] = int.Parse(s[j]);
                    if(max < n[i,j]) max = n[i,j];
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (n[i, j] == max)
                    {
                        Console.WriteLine(max);
                        Console.WriteLine("{0} {1}",i+1,j+1);
                    }

                }
            }
            
            
        }
    }
}
