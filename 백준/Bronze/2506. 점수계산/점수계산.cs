int num = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(' ');
int total = 0;
int aa = 0;
for (int i = 0; i < num; i++)
{
    if (input[i] == "0")  aa = 0;
    else
    {
        aa += 1;
        total += aa;
    }
}
Console.WriteLine(total);