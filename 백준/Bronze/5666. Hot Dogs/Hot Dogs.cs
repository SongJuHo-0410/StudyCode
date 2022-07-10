while (true)
{
    string s = Console.ReadLine();
    if (s == null) break;
    string[] ab = s.Split(' ');
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);
    double ans = (double)a / (double)b;
    Console.WriteLine("{0:0.00}",Math.Round(ans,2));
}