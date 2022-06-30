int Fibo(int num)
{
    if (num <= 1)
    {
        
        return num;
    }
    return Fibo(num - 1) + Fibo(num - 2);
    
}
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine(Fibo(num));