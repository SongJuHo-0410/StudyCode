double k = double.Parse(Console.ReadLine());
double b = 25 + (k * 0.01);
if (b < 100) Console.WriteLine(100);
else if (b > 2000) Console.WriteLine(2000);
else Console.WriteLine("{0:0.00}",b);