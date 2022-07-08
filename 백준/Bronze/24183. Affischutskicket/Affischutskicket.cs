string[] input = Console.ReadLine().Split(' ');
double c4 = 229 * 324 * double.Parse(input[0]) * 2;
double a3 = 297 * 420 * double.Parse(input[1]) * 2;
double a4 = 210 * 297 *  double.Parse(input[2]);

Console.WriteLine((c4 + a3 + a4) * 0.000001);