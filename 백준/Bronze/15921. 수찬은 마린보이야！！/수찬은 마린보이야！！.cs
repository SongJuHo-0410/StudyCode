int num = int.Parse(Console.ReadLine());
double avg = 0;
double p = 0;
double result = 0;
if (num > 0)
{
    string[] input = Console.ReadLine().Split(' ');
    for (int i = 0; i < num; i++)
    {
        avg += double.Parse(input[i]);
        p += double.Parse(input[i]) / num;
    }
    result = (avg / num) / p;
    if(p == 0)
    {
        Console.WriteLine("divide by zero");
    }
    else Console.WriteLine("{0:0.00}",Math.Round(result,3));
}
else Console.WriteLine("divide by zero");