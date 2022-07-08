string[] input = Console.ReadLine().Split(' ');
int cnt = input.Length;
for (int i = 0; i < input.Length; i++)
{
    if (string.IsNullOrEmpty(input[i])) cnt--;
}
Console.WriteLine(cnt);