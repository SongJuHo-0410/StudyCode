int num = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split();
int checker = int.Parse(Console.ReadLine());
int cnt = 0;
for (int i = 0; i < num; i++)
{
    if(checker == int.Parse(input[i]))
    {
        cnt++;
    }
}
Console.WriteLine(cnt);
