int b1 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
int b3 = int.Parse(Console.ReadLine());

int bMin = Math.Min(b1, b2);
bMin = Math.Min(bMin, b3);

int d1 = int.Parse(Console.ReadLine());
int d2 = int.Parse(Console.ReadLine());

int dMin = Math.Min(d1, d2);

Console.WriteLine(bMin + dMin - 50);