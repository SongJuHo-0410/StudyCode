int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    double num = double.Parse(s[0]);
    switch(s[1])
    {
        case "kg":
            Console.WriteLine("{0:0.0000} lb", Math.Round((num * 2.2046), 4));
            break;
        case "l":
            Console.WriteLine("{0:0.0000} g", Math.Round((num * 0.2642),4));
            break;
        case "lb":
            Console.WriteLine("{0:0.0000} kg", Math.Round((num * 0.4536),4));
            break;
        case "g":
            Console.WriteLine("{0:0.0000} l", Math.Round((num * 3.7854),4));
            break;
    }
}