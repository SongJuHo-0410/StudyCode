string[] input = Console.ReadLine().Split();
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            int n3 = int.Parse(input[2]);
            int n4 = int.Parse(input[3]);
            int[] n = { n1, n2, n3, n4 };
            int max = n1, min = n1;
            for (int i = 0; i < 4; i++)
            {
                if(n[i] > max) max = n[i];
                if(n[i] < min) min = n[i];
            }

            int maxmin = max + min;
            int com = (n1 + n2 + n3 + n4) - maxmin;
            int result = maxmin - com;
            Console.WriteLine(Math.Abs(result));