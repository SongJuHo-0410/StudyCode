string[] ap = Console.ReadLine().Split(' ');
string[] rp = Console.ReadLine().Split(' ');

double a1 = double.Parse(ap[0]);
double p1 = double.Parse(ap[1]);
double r1 = double.Parse(rp[0]);
double p2 = double.Parse(rp[1]);

double a = a1 / p1;
double r = Math.Pow(r1,2) * Math.PI / p2;

if (a > r) Console.WriteLine("Slice of pizza");
else if (a < r) Console.WriteLine("Whole pizza");