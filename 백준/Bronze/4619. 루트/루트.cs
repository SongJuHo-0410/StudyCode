while(true)
{
    string[] s = Console.ReadLine().Split();
    int b = int.Parse(s[0]);
    int n = int.Parse(s[1]);
    if (b == 0 && n == 0) break;

    double an = 0;
    int num = 0;
    double near = 0;
    while (b > an)
    {
        num++;
        if (b <= an) break;
        an = Math.Pow(num, n);
    }
    List<int> list = new List<int>();
    for (int i = num - 1; i <= num + 1; i++)
    {
        an = Math.Pow(i, n);
        near = Math.Abs(b - an);
        list.Add((int)near);
    }
    int min = list[0];
    int cnt = 0;
    for (int i = 0; i < 3; i++)
    {
        if (min >= list[i])
        {
            min = list[i];
            cnt = i - 1;
        }
    }
    Console.WriteLine(num + cnt);
}