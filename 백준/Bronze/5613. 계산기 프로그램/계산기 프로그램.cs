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
            int ans, num;
            string op;
            num = int.Parse(Console.ReadLine());
            ans = num;
            while (true)
            {
                op = Console.ReadLine();
                if (op == "=")
                {
                    Console.WriteLine(ans);
                    break;
                }
                num = int.Parse(Console.ReadLine());
                if (op == "+") ans += num;
                else if (op == "-") ans -= num;
                else if (op == "*") ans *= num;
                else if (op == "/") ans /= num;
            }
        }
    }
}
