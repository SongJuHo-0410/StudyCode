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
             while(true)
            {
                string[] s = Console.ReadLine().Split();
                if (s[0] == "#") break;
                string name = s[0];
                int age = int.Parse(s[1]);
                int weight = int.Parse(s[2]);
                if (age > 17 || weight >= 80) Console.WriteLine("{0} Senior", name);
                else Console.WriteLine("{0} Junior", name);
            }
            





        }
    }
}
