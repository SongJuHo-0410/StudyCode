int num = int.Parse(Console.ReadLine());
string[] arr = new string[num];
if (0 < num && num < 31)
{
    for (int i = 0; i < num; i++)
    {
        string[] input = Console.ReadLine().Split();
        int n1 = int.Parse(input[0]);
        int n2 = int.Parse(input[1]);
        int n3 = int.Parse(input[2]);
        
        if (n1 < 101 && n2 < 101 && n3 < 101)
        {
            if ((n1 > n2 && n2 > n3) || (n1 < n2 && n2 < n3)) arr[i] = "Ordered";
            else arr[i] = "Unordered";
        }
    }
    Console.WriteLine("Gnomes:");
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine(arr[i]);
    }
}