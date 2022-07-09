int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    string[] input = Console.ReadLine().Split(",");
    int n1 = int.Parse(input[0]);
    int n2 = int.Parse(input[1]);
    Console.WriteLine(n1 + n2);
}