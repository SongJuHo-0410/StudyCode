            int[] result = new int[30];
            for (int i = 0; i < 28; i++)
            {
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j < 30; j++)
                {
                    if (j == n-1)
                    {
                        result[j] = n;
                    }
                }
            }

            for (int i = 0; i < 30; i++)
            {
                if(result[i] == 0)
                {
                    Console.WriteLine(i+1);
                }
            }