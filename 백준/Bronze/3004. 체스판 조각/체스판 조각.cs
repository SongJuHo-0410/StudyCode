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
            int a = 1;
            int b = 2;
            int res = 0;
            for (int i = 1; i <= n; i++)
            {
                res = a * b;
                if(i % 2 == 1) a = b;
                if(i % 2 == 0) b++;
            }

            Console.WriteLine(res);


        }
    }
}
