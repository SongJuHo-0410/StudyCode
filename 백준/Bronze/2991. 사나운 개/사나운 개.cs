string[] abcd = Console.ReadLine().Split(" ");
int a = int.Parse(abcd[0]);
int b = int.Parse(abcd[1]);
int c = int.Parse(abcd[2]);
int d = int.Parse(abcd[3]);

string[] pmn = Console.ReadLine().Split(" ");

for (int i = 0; i < 3; i++)
{
    int cnt = 0;
    int dog1 = int.Parse(pmn[i]) % (a + b);
    int dog2 = int.Parse(pmn[i]) % (c + d);
    if (dog1 <= a && dog1 != 0) cnt++;
    if (dog2 <= c && dog2 != 0) cnt++;

    Console.WriteLine(cnt);
}