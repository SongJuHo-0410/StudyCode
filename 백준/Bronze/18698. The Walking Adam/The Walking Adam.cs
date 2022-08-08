int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int walk = 0;
    string s = Console.ReadLine();
    for (int j = 0; j < s.Length; j++)
    {
        if (s[j] == 'D') break;
        walk++;
    }
    Console.WriteLine(walk);
}