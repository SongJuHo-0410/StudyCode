string[] p = Console.ReadLine().Split(' ');
string[] x = Console.ReadLine().Split(' ');
bool check = false;
for (int i = 0; i < p.Length; i++)
{
    if (int.Parse(p[i]) == int.Parse(x[0]))
    {
        Console.WriteLine(i + 1);
        check = true;
    }
}
if (check == false) Console.WriteLine(0);