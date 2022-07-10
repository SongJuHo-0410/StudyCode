string[] input1 = Console.ReadLine().Split(':');
string[] input2 = Console.ReadLine().Split(':');

int[] a = new int[3];
int[] b = new int[3];

a[0] = int.Parse(input1[0]);
a[1] = int.Parse(input1[1]);
a[2] = int.Parse(input1[2]);
b[0] = int.Parse(input2[0]);
b[1] = int.Parse(input2[1]);
b[2] = int.Parse(input2[2]);

int st = a[2] + a[1] * 60 + a[0] * 3600;
int et = b[2] + b[1] * 60 + b[0] * 3600;

if (st > et) Console.WriteLine(24 * 3600 - st + et);
else Console.WriteLine(et - st);