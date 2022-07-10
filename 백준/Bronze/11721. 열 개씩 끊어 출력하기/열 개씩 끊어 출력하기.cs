string input = Console.ReadLine();
for (int i = 1; i < input.Length+1; i++)
{
    Console.Write(input[i-1]);
    if (i % 10 == 0) Console.WriteLine();
}