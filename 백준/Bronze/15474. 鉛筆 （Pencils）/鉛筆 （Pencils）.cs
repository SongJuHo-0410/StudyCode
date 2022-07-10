string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int a = int.Parse(input[1]);
int b = int.Parse(input[2]);
int c = int.Parse(input[3]);
int d = int.Parse(input[4]);
int[] ac = { a, c };
int[] bd = { b, d };
int[] acSum = new int[2];
int[] bdSum = new int[2];

for (int i = 0; i < 2; i++)
{
    while (n > acSum[i])
    {
        acSum[i] += ac[i];
        bdSum[i] += bd[i];
    }
}
int min = Math.Min(bdSum[0], bdSum[1]);
Console.WriteLine(min);