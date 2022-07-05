string[] count = Console.ReadLine().Split();
int n1 = int.Parse(count[0]);
int m1 = int.Parse(count[1]);

int[,] n = new int[n1, m1];

for (int k = 0; k < 2; k++)
{
    for (int i = 0; i < n1; i++)
    {
        string input = Console.ReadLine();
        string[] inputArr = input.Split();
        for (int j = 0; j < m1; j++)
        {
            n[i, j] += int.Parse(inputArr[j]);
        }
    }
}

for (int i = 0; i < n1; i++)
{
    for (int j = 0; j < m1; j++)
    {
        Console.Write(n[i,j] + " ");
    }
    Console.WriteLine();
}