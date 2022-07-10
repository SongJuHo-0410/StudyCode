int num = int.Parse(Console.ReadLine());
int total = 0;
for (int i = 0; i < num; i++)
{
    int n = int.Parse(Console.ReadLine());
    total += n;
}
Console.WriteLine(total - (num - 1));