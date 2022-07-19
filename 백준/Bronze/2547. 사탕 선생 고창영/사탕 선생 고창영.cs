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
                string sp = Console.ReadLine(); 
                BigInteger n = BigInteger.Parse(Console.ReadLine());
                BigInteger total = 0;
                for (int j = 0; j < n; j++)
                {
                    BigInteger s = BigInteger.Parse(Console.ReadLine());
                    total += s;
                }
                if (total % n == 0) Console.WriteLine("YES");
                else if(total % n != 0) Console.WriteLine("NO");
            }

        }
    }
}
