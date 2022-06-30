int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    string input = Console.ReadLine();

    Console.Write(input[0]);
    Console.WriteLine(input[input.Length-1]);
}