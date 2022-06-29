int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
var n1 = a2 / 100;
var n2 = (a2 % 100) / 10;
var n3 = a2 % 10;
Console.WriteLine(a1 * n3);
Console.WriteLine(a1 * n2);
Console.WriteLine(a1 * n1);
Console.WriteLine(a1 * a2);