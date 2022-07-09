string[] input = Console.ReadLine().Split(' ');
int n = int.Parse(input[0]) / 2;
int m = int.Parse(input[1]) / 2;

Console.WriteLine(Math.Min(n, m));