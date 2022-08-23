int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    List<int> list = new List<int>();
    string[] s = Console.ReadLine().Split();
    for (int j = 0; j < s.Length; j++)
    {
        list.Add(int.Parse(s[j]));
    }
    list.Sort();
    Console.WriteLine(list[0]);
}