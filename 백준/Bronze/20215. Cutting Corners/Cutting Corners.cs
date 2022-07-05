string[] input = Console.ReadLine().Split();
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            int com = n1 + n2;
            double ori = Math.Sqrt(Math.Pow(n1, 2) + Math.Pow(n2, 2));

            Console.WriteLine((double)com - ori);