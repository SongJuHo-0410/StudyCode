while(true)
{
    double num = double.Parse(Console.ReadLine());
    if (num < 0) break;
    Console.WriteLine("Objects weighing "  + "{0:0.00}"  + " on Earth will weigh " +  "{1:0.00}" + " on the moon.", num, num * 0.167);
}