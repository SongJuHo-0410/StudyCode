string input = Console.ReadLine();
            int total = 0;
            string a = "";
            if (input.Length == 2) Console.WriteLine((input[0] - '0') + (input[1] - '0'));
            else
            {
                if ((input[input.Length - 2] - '1') == 0 && (input[input.Length - 1] - '0') == 0)
                {
                    for (int i = 0; i < input.Length - 2; i++)
                    {
                        a += input[i];
                    }
                    total += 10 + int.Parse(a);
                }
                else
                {
                    for (int i = 0; i < input.Length - 1; i++)
                    {
                        a += input[i];
                    }
                    total += input[input.Length - 1] - '0' + int.Parse(a);
                }
                Console.WriteLine(total);
            }