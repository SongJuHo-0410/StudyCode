string[] input = Console.ReadLine().Split();
double hp = double.Parse(input[0]);
double per = double.Parse(input[1]);
double result = (hp * ( 100 - per ) / 100 );
if(result < 100)
    Console.WriteLine("1");
else if(result >= 100)
    Console.WriteLine("0");