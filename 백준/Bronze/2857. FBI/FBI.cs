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
            int check = 0;
            for (int i = 0; i < 5; i++)
            {
                string s = Console.ReadLine();
                if(s.Contains("FBI") && s.Contains(s.ToUpper()))
                {
                    Console.WriteLine(i + 1);
                    check++;
                }
            }
            if (check == 0) Console.WriteLine("HE GOT AWAY!");


        }
    }
}
