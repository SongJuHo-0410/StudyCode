int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int n4 = int.Parse(Console.ReadLine());
bool check = true;

if((n1 == 8 || n1 == 9) && n2 == n3 && (n4 == 8 || n4 == 9)) check = false;

if (check == true) Console.WriteLine("answer");
else Console.WriteLine("ignore");