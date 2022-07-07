int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]);
                int s = int.Parse(input[1]);
                int d = int.Parse(input[2]);

                int total = 0;

                for (int j = 0; j < n; j++)
                {
                    string[] boat = Console.ReadLine().Split(' ');
                    int di = int.Parse(boat[0]);
                    int vi = int.Parse(boat[1]);
                    if (((double)di / s) <= d) total += vi;
                }
                Console.WriteLine("Data Set " + (i+1) + ":");
                Console.WriteLine(total + "\n");
            }