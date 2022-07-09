string[] input = Console.ReadLine().Split(' ');
int n1 = int.Parse(input[0]);
int n2 = int.Parse(input[1]);
int n3 = int.Parse(input[2]);
int[] n = {n1,n2,n3};
int min = n1;
for (int i = 0; i < 3; i++)
{
    if(min > n[i]) min = n[i];
}
Console.WriteLine(n1 + n2 + n3 - min);