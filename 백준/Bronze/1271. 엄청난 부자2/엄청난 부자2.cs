using System.Numerics;

string[] input = Console.ReadLine().Split();
BigInteger all = BigInteger.Parse(input[0]);
BigInteger per = BigInteger.Parse(input[1]);

Console.WriteLine(all / per);
Console.WriteLine(all % per);