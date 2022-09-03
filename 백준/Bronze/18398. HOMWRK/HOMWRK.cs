using System.Text;

int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
	int n = int.Parse(Console.ReadLine());
	int sum = 0;
	int mul = 0;
	for (int j = 0; j < n; j++)
	{
		string[] s = Console.ReadLine().Split();
		int a = int.Parse(s[0]);
		int b = int.Parse(s[1]);

		sum = a + b;
		mul = a * b;
        Console.WriteLine("{0} {1}", sum, mul);
    }
}
