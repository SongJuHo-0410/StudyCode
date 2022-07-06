string[] real = Console.ReadLine().Split();
            string[] check = Console.ReadLine().Split();

            int re = int.Parse(real[0]) * int.Parse(real[1]);

            for (int i = 0; i < 5; i++)
            {
                Console.Write(int.Parse(check[i]) - re + " ");
            }