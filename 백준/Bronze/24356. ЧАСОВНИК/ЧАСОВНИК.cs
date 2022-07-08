string[] input = Console.ReadLine().Split(' ');
int t1 = int.Parse(input[0]);
int m1 = int.Parse(input[1]);
int t2 = int.Parse(input[2]);
int m2 = int.Parse(input[3]);
int h = 0;
int m = 0;

if (m2 >= m1) m = m2 - m1;
else if(m2 < m1)
{
    m = (60 - m1) + m2;
    t1++;
}

if (t2 >= t1) h = t2 - t1;
else if(t2 < t1)
{
    h = (24 - t1) + t2;
}

int result = (h * 60) + m;
Console.WriteLine(result + " " + result / 30);