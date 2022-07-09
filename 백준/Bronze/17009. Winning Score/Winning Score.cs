int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int a3 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
int b3 = int.Parse(Console.ReadLine());

int ar = a1 * 3 + a2 * 2 + a3 * 1;
int br = b1 * 3 + b2 * 2 + b3 * 1;

if(ar > br) Console.WriteLine("A");
if(ar < br) Console.WriteLine("B");
if(ar == br) Console.WriteLine("T");