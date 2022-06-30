string[] input1 = Console.ReadLine().Split();
int n = int.Parse(input1[0]);
int m = int.Parse(input1[1]);
int k = int.Parse(input1[2]);

Console.Write(k/m + " " + k%m);
