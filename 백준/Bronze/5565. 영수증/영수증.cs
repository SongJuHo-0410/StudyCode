int total = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < 9; i++)
{
    int price = int.Parse(Console.ReadLine());
    sum += price;
}
Console.WriteLine(total - sum);