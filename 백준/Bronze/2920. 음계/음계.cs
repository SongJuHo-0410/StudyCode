string[] input = Console.ReadLine().Split(' ');
int n1 = int.Parse(input[0]);
int n2 = int.Parse(input[1]);
int n3 = int.Parse(input[2]);
int n4 = int.Parse(input[3]);
int n5 = int.Parse(input[4]);
int n6 = int.Parse(input[5]);
int n7 = int.Parse(input[6]);
int n8 = int.Parse(input[7]);

if (n1 > n2 && n2 > n3 && n3 > n4 && n4 > n5 && n5 > n6 && n6 > n7 && n7 > n8)
{
    Console.WriteLine("descending");
}
else if (n8 > n7 && n7 > n6 && n6 > n5 && n5 > n4 && n4 > n3 && n3 > n2 && n2 > n1)
{
    Console.WriteLine("ascending"); 
}
else Console.WriteLine("mixed");