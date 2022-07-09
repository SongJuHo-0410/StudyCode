int s = int.Parse(Console.ReadLine());
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int price = 250;
int normal = 250;

int ExtraIcecreamPrice(int s,int a, int b)
{
    double calc = ((double)s - a) / b;
    if(calc != (int)calc) calc = (int)calc + 1;
    price += (int)calc * 100;
    return price;
}

if (a >= s) Console.WriteLine(normal);
else Console.WriteLine(ExtraIcecreamPrice(s,a,b));