int num = int.Parse(Console.ReadLine());
for (int i = 0; i < num; i++)
{
    string[] input = Console.ReadLine().Split();
    int n1 = int.Parse(input[0]);
    int n2 = int.Parse(input[1]);
    if (n2 > n1) Console.WriteLine("NO BRAINS");
    else Console.WriteLine("MMM BRAINS");
}