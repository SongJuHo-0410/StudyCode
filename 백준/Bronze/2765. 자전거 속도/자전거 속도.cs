double pi = 3.1415927;
int cnt = 0;
while (true)
{
    cnt++;
    double diameter, rotated, sec;
    string[] s = Console.ReadLine().Split(" ");
    diameter = double.Parse(s[0]);
    rotated = double.Parse(s[1]);
    sec = double.Parse(s[2]);
    if (rotated == 0) break;
    double moved = diameter / (5280.0 * 12.0) * rotated * pi;
    Console.WriteLine("Trip #{0}: {1:0.00} {2:0.00}", cnt, moved, moved / sec * 3600);
}