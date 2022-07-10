int num = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(' ');
int ans1 = 0;
int ans2 = 0;
for (int i = 0; i < num; i++)
{
    ans1 += (int.Parse(input[i]) / 30 + 1) * 10;
    ans2 += (int.Parse(input[i]) / 60 + 1) * 15;
}

if (ans1 == ans2) Console.WriteLine("Y M " + ans1);
else if(ans1 > ans2) Console.WriteLine("M " + ans2);
else if(ans2 > ans1) Console.WriteLine("Y " + ans1);