string[] n1 = Console.ReadLine().Split(' ');
int p1 = int.Parse(n1[1]) - int.Parse(n1[0]);

string[] n2 = Console.ReadLine().Split(' ');
int p2 = p1 + int.Parse(n2[1]) - int.Parse(n2[0]);

string[] n3 = Console.ReadLine().Split(' ');
int p3 = p2 + int.Parse(n3[1]) - int.Parse(n3[0]);

string[] n4 = Console.ReadLine().Split(' ');
int p4 = p3 + int.Parse(n4[1]) - int.Parse(n4[0]);

int[] p = {p1,p2,p3,p4};
int max = p1;

for (int i = 0; i < 4; i++)
{
    if(max < p[i]) max = p[i];
}
Console.WriteLine(max);