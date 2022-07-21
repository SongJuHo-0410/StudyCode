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

            string[] s = Console.ReadLine().Split(); //입력
            List<int> list = new List<int>(); //오름차순으로 정렬하기 위한 리스트
            //리스트에 값 저장
            for (int i = 0; i < 3; i++)
            {
                list.Add(int.Parse(s[i]));
            }

            list.Sort(); //정렬

            int r1 = list[1] - list[0];
            int r2 = list[2] - list[1];
            if (r1 == r2) list.Add(list[2] + r1);
            else if (2 * r1 == r2) list.Add(list[1] + r1);
            else if (2 * r2 == r1) list.Add(list[0] + r2);

            Console.WriteLine(list[3]);
            



        }
    }
}
