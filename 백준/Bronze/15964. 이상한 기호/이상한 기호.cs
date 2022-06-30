string[] input1 = Console.ReadLine().Split();
long A = long.Parse(input1[0]);
long B = long.Parse(input1[1]);

Console.WriteLine((A + B) * (A - B));