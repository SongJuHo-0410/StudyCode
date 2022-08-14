string[] s = Console.ReadLine().Split();
double h = double.Parse(s[0]) / (double.Parse(s[2]) + 1);
double w = double.Parse(s[1]) / (double.Parse(s[3]) + 1);

double result = Math.Ceiling(h) * Math.Ceiling(w);
Console.WriteLine(result);