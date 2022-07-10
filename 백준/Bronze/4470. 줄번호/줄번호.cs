int num = int.Parse(Console.ReadLine());
string[] n = new string[num];
for (int i = 0; i < num; i++)
{
    string input = Console.ReadLine();
    Console.WriteLine(i+1 + ". " + input);
}