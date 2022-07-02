long origInalTotal = long.Parse(Console.ReadLine());
int count = int.Parse(Console.ReadLine());
long result = 0;

for (int i = 0; i < count; i++)
{
    string[] price_count = Console.ReadLine().Split();
    result += long.Parse(price_count[0]) * long.Parse(price_count[1]);
}

if (result == origInalTotal)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");