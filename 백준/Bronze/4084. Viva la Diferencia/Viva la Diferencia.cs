while(true)
{
    string[] s = Console.ReadLine().Split();
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    int c = int.Parse(s[2]);
    int d = int.Parse(s[3]);
    if (a == 0 && b == 0 && c == 0 && d == 0) break;
    int count = 0;
    int A = int.Parse(s[0]);
    while(true)
    {
        if (a == b && b == c && c == d) break;
        a = Math.Abs(a - b);
        b = Math.Abs(b - c);
        c = Math.Abs(c - d);
        d = Math.Abs(d - A);
        A = a;
        //Console.WriteLine("{0} {1} {2} {3}",a, b, c, d);
        count++;
    }
    Console.WriteLine(count);
}