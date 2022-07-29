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
            double perPrice = int.Parse(s[1]);
            double roomPrice = 0;
            int roomTotal = 0;
            int bedroom = 0;
            for (int i = 0; i < int.Parse(s[0]); i++)
            {
                string[] r = Console.ReadLine().Split();
                roomTotal += int.Parse(r[0]);
                if (r[1] != "balcony") roomPrice += double.Parse(r[0]);
                if (r[1] == "balcony") roomPrice += double.Parse(r[0]) / 2;
                if (r[1] == "bedroom") bedroom += int.Parse(r[0]);
            }
            Console.WriteLine(roomTotal);
            Console.WriteLine(bedroom);
            Console.WriteLine(roomPrice * perPrice);
            
        }
    }
}
