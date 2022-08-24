using System.Reflection;

while (true)
{
    string[] s = Console.ReadLine().Split();
    int own = int.Parse(s[0]);
    int lost = int.Parse(s[1]);
    if (own == 0 && lost == 0) break;
    int result = own - lost;
    int two = 0;
    int three = 0;
    while(true)
    {
        if (result <= 1) break;
        else if(result != 0)
        {
            if (result == 3)
            {
                result = 0;
                three++;
            }
            else 
            {
                result -= 2;
                two++;
            }
            
        }
    }
    Console.WriteLine("{0} {1}",two,three);
}