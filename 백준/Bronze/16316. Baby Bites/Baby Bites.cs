int num = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(' ');
bool a = true;
for (int i = 0; i < num; i++)
{
    if (input[i] == "mumble") a = true;
    else if(int.Parse(input[i]) != i + 1)
    {
        Console.WriteLine("something is fishy");
        a = false;
        break;
    }
}
if (a == true) Console.WriteLine("makes sense");