int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
	int p1 = 0;
	int p2 = 0;
	for (int j = 0; j < n; j++)
	{
		string[] s = Console.ReadLine().Split();
		if ((s[0] == "S" && s[1] == "P") || (s[0] == "R" && s[1] == "S") || (s[0] == "P" && s[1] == "R")) p1++;
		else if ((s[0] == "P" && s[1] == "S") || (s[0] == "S" && s[1] == "R") || (s[0] == "R" && s[1] == "P")) p2++;
    }
	if (p1 == p2) Console.WriteLine("TIE");
	else if (p1 > p2) Console.WriteLine("Player 1");
	else if (p1 < p2) Console.WriteLine("Player 2");
}