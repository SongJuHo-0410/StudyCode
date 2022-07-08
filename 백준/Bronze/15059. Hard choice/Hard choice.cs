string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();

            int[] n = new int[3];

            for (int i = 0; i < 3; i++)
            {
                if (int.Parse(input2[i]) >= int.Parse(input1[i]))
                {
                    n[i] = int.Parse(input2[i]) - int.Parse(input1[i]);
                }
                else n[i] = 0;
                
            }
            int result = 0;
            for (int i = 0; i < 3; i++)
            {
                result += n[i];
            }
            Console.WriteLine(result);