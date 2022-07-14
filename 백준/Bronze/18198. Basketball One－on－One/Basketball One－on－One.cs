string result = Console.ReadLine();
            int a = 0;
            int b = 0;
            for (int i = 0; i < result.Length - 1; i+=2)
            {
                if (result[i] == 'A') a += int.Parse(result[i + 1].ToString());
                if (result[i] == 'B') b += int.Parse(result[i + 1].ToString());
            }
            if (a > b) Console.WriteLine("A");
            else if (a < b) Console.WriteLine("B");