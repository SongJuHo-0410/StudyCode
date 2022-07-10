string[] input = Console.ReadLine().Split(' ');
double n1 = int.Parse(input[0]);
double n2 = int.Parse(input[1]);
double a = n1 % 4;
double b = n2 % 4;
if (n1 % 4 == 0) a = 4;
if (n2 % 4 == 0) b = 4;


double c = (int)(n1 / 4);
double d = (int)(n2 / 4);
if (c < n1 / 4) c += 1;
if (d < n2 / 4) d += 1;

double result = Math.Abs(a - b) + Math.Abs(c - d);
Console.WriteLine(result);