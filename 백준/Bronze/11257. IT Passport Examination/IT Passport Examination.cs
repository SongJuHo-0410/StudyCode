            int count = int.Parse(Console.ReadLine());
            for (int k = 0; k < count; k++)
            {
                string[] input = Console.ReadLine().Split();
                int applicant = int.Parse(input[0]);
                string result = "PASS";
                int total = 0;
                double[] check = { 35, 25, 40 };
                for (int i = 1; i < 4; i++)
                {
                    if (double.Parse(input[i]) < check[i - 1] * 0.3)
                    {
                        result = "FAIL";   
                    }
                    total += int.Parse(input[i]);
                    
                }
                if(total < 55) result = "FAIL";
                Console.WriteLine(applicant + " " + total + " " + result);
            }