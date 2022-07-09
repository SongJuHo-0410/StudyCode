int a = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int t = int.Parse(Console.ReadLine());
int ax = 0;
int by = 0;

if (t > 30) ax = (t - 30) * x;
if (t > 45) by = (t - 45) * y;

int ans1 = a + ax * 21;
int ans2 = b + by * 21;
Console.WriteLine(ans1 + " " + ans2);