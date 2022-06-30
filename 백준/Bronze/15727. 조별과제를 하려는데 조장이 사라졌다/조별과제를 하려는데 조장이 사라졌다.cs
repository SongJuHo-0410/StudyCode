int distance = int.Parse(Console.ReadLine());
int result = 0;
result += distance / 5;
if (distance % 5 != 0)
{
    result++;
}
Console.WriteLine(result);