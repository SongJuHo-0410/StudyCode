string[] input = Console.ReadLine().Split();
long x = long.Parse(input[0]);
long k = long.Parse(input[1]);
if (x > k)
{
    long a = 0, b = 0, c = 0;
    if (7000 * k <= 1000 * x) a = 7000 * k;
    if (3500 * k <= 1000 * x) b = 3500 * k;
    if (1750 * k <= 1000 * x) c = 1750 * k;
    long max = Math.Max(a, b);
    max = Math.Max(max, c);
    Console.WriteLine(max);
}
else Console.WriteLine(0);