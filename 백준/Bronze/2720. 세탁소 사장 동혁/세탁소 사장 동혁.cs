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
                int q = 0;
                int d = 0;
                int ni = 0;
                int p = 0;
                int change = int.Parse(Console.ReadLine());
                
                while(change >= 25)
                {
                    change -= 25;
                    q++;
                }
                while(change >= 10)
                {
                    change -= 10;
                    d++;
                }
                while(change >= 5)
                {
                    change -= 5;
                    ni++;
                }
                while(change > 0)
                {
                    change--;
                    p++;
                }
                Console.WriteLine("{0} {1} {2} {3}", q, d, ni, p);
            }
            

            
            
        }
    }
}
