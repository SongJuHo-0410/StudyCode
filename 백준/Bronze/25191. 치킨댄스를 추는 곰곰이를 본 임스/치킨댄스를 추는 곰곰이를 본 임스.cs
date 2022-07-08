int num = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(' ');
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int result = (a / 2) + b;
if (num < result) Console.WriteLine(num);
else Console.WriteLine(result);