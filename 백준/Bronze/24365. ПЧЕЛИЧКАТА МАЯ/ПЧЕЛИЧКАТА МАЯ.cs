string[] input = Console.ReadLine().Split(' ');
int n1 = int.Parse(input[0]);
int n2 = int.Parse(input[1]);
int n3 = int.Parse(input[2]);

int total = (n1 + n2 + n3) / 3;

int result = (total - n1) + (n3 - total);
Console.WriteLine(result);