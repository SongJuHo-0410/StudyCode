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

            /*
                1*2=2    1번
                2*2=4	2번
                2*3=6    3번
                3*3=9    4번
                3*4=12    5번
                4*4=16    6번
                4*5=20    7번
                5*5=25    8번
            */
            int n = int.Parse(Console.ReadLine());
            int a = 1; //기준 1
            int b = 2; //기준 2
            int res = 0; //결과 값
            for (int i = 1; i <= n; i++)
            {
                res = a * b; //값을 먼저 저장
                if(i % 2 == 1) a = b; //홀수인 경우
                if(i % 2 == 0) b++; //짝수인 경우
            }

            Console.WriteLine(res);


        }
    }
}
