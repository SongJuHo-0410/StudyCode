int Factorial(int num)
{
    if(num <= 1)
    {
        return 1;
    }
    return Factorial(num - 1) * num;
}

int num = int.Parse(Console.ReadLine());
Console.WriteLine(Factorial(num));