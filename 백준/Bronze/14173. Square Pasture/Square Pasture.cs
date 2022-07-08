string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();
            int x1 = int.Parse(input1[0]), y1 = int.Parse(input1[1]), x2 = int.Parse(input1[2]), y2 = int.Parse(input1[3]);
            int a1 = int.Parse(input2[0]), b1 = int.Parse(input2[1]), a2 = int.Parse(input2[2]), b2 = int.Parse(input2[3]);

            int ans1 = Math.Max(x2, a2) - Math.Min(x1, a1);
            int ans2 = Math.Max(y2, b2) - Math.Min(y1, b1);
            int ans = Math.Max(ans1,ans2);
            Console.WriteLine(ans * ans);