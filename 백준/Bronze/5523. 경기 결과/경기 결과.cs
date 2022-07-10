int n = int.Parse(Console.ReadLine());
int ac = 0, bc = 0;
for (int i = 0; i < n; i++)
{
    string[] ab = Console.ReadLine().Split(' ');
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);
    if (a > b) ac++;
    else if (a < b) bc++;
}
Console.WriteLine(ac + " " + bc);