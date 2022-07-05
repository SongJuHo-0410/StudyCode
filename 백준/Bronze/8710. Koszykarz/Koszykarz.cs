string[] input = Console.ReadLine().Split();
            int now = int.Parse(input[0]);
            int need = int.Parse(input[1]);
            int grow = int.Parse(input[2]);
            int cnt = 0;
            for (int i = now; i < need; i += grow)
            {
                cnt++;
            }
            Console.WriteLine(cnt);