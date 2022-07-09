string[] input = Console.ReadLine().Split(' ');
long a = long.Parse(input[0]);
long b = long.Parse(input[1]);

if (a >= b) Console.WriteLine(b);
else if(a < b) Console.WriteLine(a + 1);