int n = int.Parse(Console.ReadLine());
int result = -1;
int diff = 0; //now
int before = 0;
int count = 0;
List<int> list = new List<int>();

for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split();
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    if(a <= b) list.Add(b);
}

list.Sort();

if(list.Count == 0) Console.WriteLine(-1);
else if(list.Count != 0) Console.WriteLine(list[0]);
