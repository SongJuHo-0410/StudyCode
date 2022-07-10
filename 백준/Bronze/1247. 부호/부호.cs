using System.Numerics;
for (int i = 0; i < 3; i++)
{
    int count = int.Parse(Console.ReadLine());
    BigInteger total = 0;
    for (int j = 0; j < count; j++)
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        total += n;
    }
    if (total == 0) Console.WriteLine(0);
    else if(total > 0 ) Console.WriteLine("+");
    else Console.WriteLine("-");
}