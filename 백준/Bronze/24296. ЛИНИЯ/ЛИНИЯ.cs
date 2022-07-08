int num = int.Parse(Console.ReadLine());
            while(num % 2 != 0)
            {
                num -= num / 2;
            }
            Console.WriteLine(num);