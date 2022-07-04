string[] p1 = Console.ReadLine().Split();
string[] p2 = Console.ReadLine().Split();
int total1 = 0;
int total2 = 0;
for (int i = 0; i < 4; i++)
{
    total1 += int.Parse(p1[i]);
}
for(int i = 0; i < 4; i++)
{
    total2 += int.Parse(p2[i]);
}
int max = Math.Max(total1, total2);

Console.WriteLine(max);