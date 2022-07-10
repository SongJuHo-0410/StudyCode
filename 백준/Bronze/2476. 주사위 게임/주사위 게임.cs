int count = int.Parse(Console.ReadLine());
int[] total = new int[count];
for (int i = 0; i < count; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int n1 = int.Parse(input[0]);
    int n2 = int.Parse(input[1]);
    int n3 = int.Parse(input[2]);

    if (n1 == n2 && n2 == n3 && n1 == n3) total[i] = 10000 + n1 * 1000;
    else if (n1 == n2) total[i] = 1000 + n1 * 100;
    else if (n2 == n3) total[i] = 1000 + n2 * 100;
    else if (n3 == n1) total[i] = 1000 + n3 * 100;
    else if (n1 > n2 && n1 > n3) total[i] = n1 * 100;
    else if (n2 > n1 && n2 > n3) total[i] = n2 * 100;
    else if (n3 > n1 && n3 > n2) total[i] = n3 * 100;
}
int max = total[0];
for (int i = 0; i < count; i++)
{
    if(max < total[i]) max = total[i];
}
Console.WriteLine(max);