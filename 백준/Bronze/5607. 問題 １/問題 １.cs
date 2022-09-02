int t = int.Parse(Console.ReadLine());
int ap = 0;
int bp = 0;
for (int i = 0; i < t; i++)
{
    string[] s = Console.ReadLine().Split();
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);

    if (a > b) ap += a + b;
    if (a < b) bp += a + b;
    if (a == b)
    {
        ap += a;
        bp += b;
    }
}
Console.WriteLine("{0} {1}",ap,bp);