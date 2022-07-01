string input = Console.ReadLine();
double result = 0;
for (int i = 0; i < input.Length; i++)
{   
    int n1 = int.Parse(input[i].ToString());
    result += Math.Pow(n1, 5);
    
}
Console.WriteLine(result);