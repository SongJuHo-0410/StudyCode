using System.Numerics;
string[] input = Console.ReadLine().Split(' ');
long n1 = long.Parse(input[0]);
long n2 = long.Parse(input[1]);
long n3 = long.Parse(input[2]);

double ans1 = (double)(n1 * n2) / n3;
double ans2 = ((double)n1 / n2) * n3;
Console.WriteLine(Math.Max((long)ans1,(long)ans2));