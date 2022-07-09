string[] input1 = Console.ReadLine().Split();
double a1 = int.Parse(input1[0]);
double c1 = int.Parse(input1[1]);
double e1 = int.Parse(input1[2]);

string[] input2 = Console.ReadLine().Split();
double a2 = int.Parse(input2[0]);
double c2 = int.Parse(input2[1]);
double e2 = int.Parse(input2[2]);

if (a2 >= a1 && c2 >= c1 && e2 >= e1) Console.WriteLine("A");
else if (a2 >= (a1 / 2) && c2 >= c1 && e2 >= e1) Console.WriteLine("B");
else if (c2 >= c1 && e2 >= e1) Console.WriteLine("C");
else if (c2 >= (c1 / 2) && e2 >= e1) Console.WriteLine("D");
else Console.WriteLine("E");