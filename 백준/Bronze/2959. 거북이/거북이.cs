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
            List<int> list = new List<int>();
            string[] s = Console.ReadLine().Split();
            list.Add(int.Parse(s[0]));
            list.Add(int.Parse(s[1]));
            list.Add(int.Parse(s[2]));
            list.Add(int.Parse(s[3]));
            
            list.Sort();

            Console.WriteLine(list[0] * list[2]);

        }
    }
}
