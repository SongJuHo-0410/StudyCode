int ori = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int cnt = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (ori == int.Parse(input[i])) cnt++;
            }
            Console.WriteLine(cnt);