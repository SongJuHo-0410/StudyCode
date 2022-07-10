
string[] n1 = Console.ReadLine().Split(' ');
int p1 = int.Parse(n1[1]) - int.Parse(n1[0]);

string[] n2 = Console.ReadLine().Split(' ');
int p2 = p1 + int.Parse(n2[1]) - int.Parse(n2[0]);

string[] n3 = Console.ReadLine().Split(' ');
int p3 = p2 + int.Parse(n3[1]) - int.Parse(n3[0]);

string[] n4 = Console.ReadLine().Split(' ');
int p4 = p3 + int.Parse(n4[1]) - int.Parse(n4[0]);

string[] n5 = Console.ReadLine().Split(' ');
int p5 = p4 + int.Parse(n5[1]) - int.Parse(n5[0]);

string[] n6 = Console.ReadLine().Split(' ');
int p6 = p5 + int.Parse(n6[1]) - int.Parse(n6[0]);

string[] n7 = Console.ReadLine().Split(' ');
int p7 = p6 + int.Parse(n7[1]) - int.Parse(n7[0]);

string[] n8 = Console.ReadLine().Split(' ');
int p8 = p7 + int.Parse(n8[1]) - int.Parse(n8[0]);

string[] n9 = Console.ReadLine().Split(' ');
int p9 = p8 + int.Parse(n9[1]) - int.Parse(n9[0]);

string[] n10 = Console.ReadLine().Split(' ');
int p10 = p9 + int.Parse(n10[1]) - int.Parse(n10[0]);

int[] p = {p1,p2,p3,p4,p5,p6,p7,p8,p9,p10};
int max = p1;

for (int i = 0; i < 10; i++)
{
    if(max < p[i]) max = p[i];
}
Console.WriteLine(max);


