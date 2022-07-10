while(true)
{
    string[] input = Console.ReadLine().Split(' ');
    long n1 = long.Parse(input[0]);
    string ch = input[1];
    long n2 = long.Parse(input[2]);

    if (n1 == 0 && n2 == 0 && ch == "W") break;

    long result = 0;

    if (ch == "W") result = n1 - n2;
    else if(ch == "D") result = n1 + n2;

    if (result < -200) Console.WriteLine("Not allowed");
    else Console.WriteLine(result);
}