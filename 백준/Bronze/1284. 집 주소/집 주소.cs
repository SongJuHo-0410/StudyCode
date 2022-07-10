while(true)
{
    string num = Console.ReadLine();
    if (num == "0") break;
    int total = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if ((num[i] - 48) == 1) total += 2;
        else if ((num[i] - 48) == 0) total += 4;
        else total += 3;
    }
    Console.WriteLine(total + 2 + (num.Length - 1));
}