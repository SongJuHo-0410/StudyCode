int people = int.Parse(Console.ReadLine());
int cnt = 0;
for (int i = 0; i < people; i++)
{
    int vote = int.Parse(Console.ReadLine());
    if (vote == 0) cnt--;
    else if (vote == 1) cnt++;
}
if (cnt > 0) Console.WriteLine("Junhee is cute!");
else Console.WriteLine("Junhee is not cute!");