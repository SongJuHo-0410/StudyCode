int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
int rimit = k + 60;
int price = 0;
if (n > rimit) price = ((n - rimit) * 3000) + (rimit * 1500);
else price = n * 1500;

Console.WriteLine(price);