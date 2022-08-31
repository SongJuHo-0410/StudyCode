while(true)
{
    int t = int.Parse(Console.ReadLine());
    if (t == -1) break;

    int previousHour = 0;
    int miles = 0;

    for (int i = 0; i < t; i++)
    {
        string[] input = Console.ReadLine().Split(" ");
        int speed = int.Parse(input[0]);
        int hour = int.Parse(input[1]) - previousHour;

        miles += speed * hour;
        previousHour = int.Parse(input[1]);
    }
    Console.WriteLine("{0} miles",miles);
}
