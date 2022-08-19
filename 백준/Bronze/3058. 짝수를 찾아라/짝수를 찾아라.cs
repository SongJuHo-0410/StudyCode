int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    List<int> list = new List<int>();
    string[] s = Console.ReadLine().Split();
	for (int j = 0; j < 7; j++)
	{
		if (int.Parse(s[j]) % 2 == 0) list.Add(int.Parse(s[j]));
	}
	list.Sort();
	int result = 0;
	for (int j = 0; j < list.Count; j++)
	{
		result += list[j];
	}

	Console.WriteLine("{0} {1}", result, list[0]);
}