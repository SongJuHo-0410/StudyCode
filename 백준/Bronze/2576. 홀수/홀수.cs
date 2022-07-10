int[] n = new int[7];
int total = 0;
int min = 0;
for (int i = 0; i < 7; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num % 2 != 0)
    {
        n[i] = num;
        total += n[i];
        min = num;
    }
    else n[i] = 100;
}
for (int i = 0; i < 7; i++)
{
    if(n[i] < min) min=n[i];
}
if (total > 0)
{
    Console.WriteLine(total);
    Console.WriteLine(min);
}
else Console.WriteLine(-1);