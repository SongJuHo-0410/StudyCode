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
            string[] s = Console.ReadLine().Split();
            long n = long.Parse(s[0]);
            long k = long.Parse(s[1]);

            int check = 0;

            for (int i = 1; i <= n; i++)
            {
                if((n%i) == 0)
                {
                    check++;
                    if(check == k)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    
                }
            }
            if (check < k) Console.WriteLine(0);



        }
    }
}
