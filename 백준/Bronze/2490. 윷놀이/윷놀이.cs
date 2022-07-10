for (int i = 0; i < 3; i++)
{
    string[] input = Console.ReadLine().Split();
    int n1 = int.Parse(input[0]);
    int n2 = int.Parse(input[1]);
    int n3 = int.Parse(input[2]);
    int n4 = int.Parse(input[3]);

    int total = 4 - (n1 + n2 + n3 + n4);

    if (total == 0) Console.WriteLine("E");
    if (total == 1) Console.WriteLine("A");
    if (total == 2) Console.WriteLine("B");
    if (total == 3) Console.WriteLine("C");
    if (total == 4) Console.WriteLine("D");
}