string input = Console.ReadLine();
            
            string rep(string input)
            {
                string num = ((input[0] - 48) * input.Length).ToString();
                return num;
            }

            while(true)
            {
                string num = rep(input);
                if(num == input)
                {
                    Console.WriteLine("FA");
                    break;
                }
                input = num;
            }