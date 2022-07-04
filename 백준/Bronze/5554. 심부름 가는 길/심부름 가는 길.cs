int p1 = int.Parse(Console.ReadLine());
int p2 = int.Parse(Console.ReadLine());
int p3 = int.Parse(Console.ReadLine());
int p4 = int.Parse(Console.ReadLine());
int cnt = 0;
int total = p1 + p2 + p3 + p4;
while(total > 60 || total ==60)
{
    total -= 60;
    cnt++;
}
Console.WriteLine(cnt);
Console.WriteLine(total);
