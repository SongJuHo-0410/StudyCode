int w1, h1, w2, h2;

w1 = int.Parse(Console.ReadLine());
h1 = int.Parse(Console.ReadLine());
w2 = int.Parse(Console.ReadLine());
h2 = int.Parse(Console.ReadLine());
int b1 = w1 * 2 + h1 * 2 + 4;
int b2 = w2 * 2 + h2 * 2 + 4;

Console.WriteLine(b1 + b2 - 4 - (Math.Min(w1,w2) * 2));