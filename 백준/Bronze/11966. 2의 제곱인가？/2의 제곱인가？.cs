long n = long.Parse(Console.ReadLine());
            bool tf = false;
            for (int i = 0; i <= 30; i++)
            {
                if (n == Math.Pow(2, i))
                {
                    tf = true;
                    break;
                }
            }
            if (tf == false) Console.WriteLine(0);
            else if (tf == true) Console.WriteLine(1);