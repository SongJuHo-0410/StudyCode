while(true)
{
    int result = 1;
    int num = int.Parse(Console.ReadLine());
    if (num == 0) break;
    result += calc(num);
    Console.WriteLine("{0} => {1}",num,result);
    
}

 static int calc(int num)
{
    int result = 0;
    for (int i = 1; i < num; i++)
    {
        result += 2 * i;
    }
    return result;
}