int count = 1;
while(true)
{
    string[] s = Console.ReadLine().Split();
    if (s[1] == "0") break;
    double inch = double.Parse(s[0]);
    double torque = int.Parse(s[1]);
    double second = double.Parse(s[2]);

    double circle = 2 * Math.PI * (inch / 2);
    double round = ((torque * circle) / 12);
    double distance = round / 5280;

    double speed = (distance * 3600) / second;

    Console.WriteLine("Trip #{0}: {1:0.00} {2:0.00}", count, distance, speed);
    count++;
}