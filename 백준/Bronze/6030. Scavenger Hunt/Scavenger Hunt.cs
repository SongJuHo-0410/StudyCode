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
            string[] s = Console.ReadLine().Split(' ');
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            for (int i = 1; i <= int.Parse(s[0]); i++)
            {
                if(int.Parse(s[0]) % i == 0) list1.Add(i);
            }
            for (int i = 1; i <= int.Parse(s[1]); i++)
            {
                if (int.Parse(s[1]) % i == 0) list2.Add(i);
            }

            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    Console.WriteLine("{0} {1}", list1[i], list2[j]);
                }
            }
        }
    }
}
