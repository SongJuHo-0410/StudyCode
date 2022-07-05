            string[] input = Console.ReadLine().Split();
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            int n3 = int.Parse(input[2]);
            string winner = "";
            if (n1 == n2 && n1 == n3) winner = "*";
            else if(n2 == n3) winner = "A";
            else if(n1 == n3) winner = "B";
            else if(n1 == n2) winner = "C";

            Console.Write(winner);