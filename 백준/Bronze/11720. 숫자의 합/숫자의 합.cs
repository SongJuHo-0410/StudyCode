                int count = int.Parse(Console.ReadLine());
         
                int result = 0;
                string num = Console.ReadLine();
                for (int i = 0; i < count; i++)
                {
                    result += num[i] - 48;
                }
                Console.WriteLine(result);