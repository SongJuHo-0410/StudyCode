string[] input = Console.ReadLine().Split(' ');
int a = int.Parse(input[0]) * 7;
int p = int.Parse(input[1]) * 13;

if (a > p) Console.WriteLine("Axel");
else if (a < p) Console.WriteLine("Petra");
else if (a == p) Console.WriteLine("lika");