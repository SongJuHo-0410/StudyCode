int a = int.Parse(Console.ReadLine());
while (true)
{
    int n = int.Parse(Console.ReadLine());
    if (n == 0) break;
    else if(n % a != 0) Console.WriteLine(n + " is NOT a multiple of " + a + ".");
    else if(n % a == 0) Console.WriteLine(n + " is a multiple of " + a + ".");
}