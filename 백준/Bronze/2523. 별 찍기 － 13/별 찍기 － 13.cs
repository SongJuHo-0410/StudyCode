int count = int.Parse(Console.ReadLine());
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = 1; i < count; i++)
{
    for (int j = count; j > i; j--) 
    {
        Console.Write("*");
    }
    Console.WriteLine();
}