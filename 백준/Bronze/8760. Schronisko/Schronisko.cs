int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        string[] wk = Console.ReadLine().Split(' ');
        int w = int.Parse(wk[0]);
        int k = int.Parse(wk[1]);
        Console.WriteLine(w * k / 2);    
    }
