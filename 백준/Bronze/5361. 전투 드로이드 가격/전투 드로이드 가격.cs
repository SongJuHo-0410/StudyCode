int n = int.Parse(Console.ReadLine());

double[] a = { 350.34, 230.9, 190.55, 125.3, 180.9 };

for (int k = 0; k < n; k++)
{
    double sum = 0;
    string[] x = Console.ReadLine().Split(' ');
    for (int i = 0; i < 5; i++)
    {
        sum += a[i] * double.Parse(x[i]);
    }
    Console.WriteLine("${0:0.00}", sum);
}