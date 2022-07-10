using System.Numerics;
BigInteger n1 = BigInteger.Parse(Console.ReadLine());
string oper = Console.ReadLine();
BigInteger n2 = BigInteger.Parse(Console.ReadLine());

if (oper == "*") Console.WriteLine(n1 * n2);
else if(oper == "+") Console.WriteLine(n1+ n2);