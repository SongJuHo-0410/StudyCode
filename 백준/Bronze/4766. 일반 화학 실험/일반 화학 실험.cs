double temp1 = double.Parse(Console.ReadLine());
double result = temp1;
while(true)
{
    double temp2 = double.Parse(Console.ReadLine());
    if (temp2 == 999) break;
    result = temp2 - temp1;
    temp1 = temp2;
    Console.WriteLine("{0:0.00}",result);
}
