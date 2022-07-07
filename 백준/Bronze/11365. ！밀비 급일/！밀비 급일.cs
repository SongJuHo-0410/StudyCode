while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") break;
                char[] reverse;
                reverse = input.ToCharArray().Reverse().ToArray();
                Console.WriteLine(reverse);
            }