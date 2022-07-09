int num = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(' ');
int cnt = 0;
for (int i = 0; i < num; i++)
{
    if(input[i] == "he" || input[i] == "him" || input[i] == "she" || input[i] == "her") cnt++;
}
Console.WriteLine(cnt);