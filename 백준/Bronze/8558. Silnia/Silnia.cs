int count = int.Parse(Console.ReadLine());
            int total = 0;
            int Factorial(int num)
            {
                if(num < 1) return 1;
                return Factorial(num - 1) * num;
            }
            Console.WriteLine(Factorial(count) % 10);