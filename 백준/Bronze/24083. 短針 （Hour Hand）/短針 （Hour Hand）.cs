int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int result = a + b;
if (a + b > 12)
{
    while(result > 12) result -= 12;
}
Console.WriteLine(result);