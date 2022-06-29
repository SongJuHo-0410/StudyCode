String[] all = Console.ReadLine().Split();
var a = double.Parse(all[0]);
var b = double.Parse(all[1]);
var c = double.Parse(all[2]);
Console.WriteLine((a + b) % c);
Console.WriteLine(((a % c) + (b % c)) % c);
Console.WriteLine((a * b) % c);
Console.WriteLine(((a % c) * (b % c)) % c);