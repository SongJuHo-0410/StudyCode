string input = Console.ReadLine();
for (int i = 0; i < input.Length; i++)
{
    if(input[i] == 'C' || input[i] == 'A' || input[i] =='M' || input[i] == 'B' || input[i] == 'R' || input[i] == 'I' || input[i] == 'D' || input[i] == 'G' || input[i] == 'E')
    {
        continue;
    }
    else Console.Write(input[i]);
}