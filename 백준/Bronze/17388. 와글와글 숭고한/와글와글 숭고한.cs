string[] input = Console.ReadLine().Split();
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            int n3 = int.Parse(input[2]);
            int total = n1 + n2 + n3;
            string a = "";
            if (total > 99) Console.WriteLine("OK");
            else if(total < 100)
            {
                if (n1 < n2 && n1 < n3) Console.WriteLine("Soongsil");
                else if (n2 < n1 && n2 < n3) Console.WriteLine("Korea");
                else if (n3 < n1 && n3 < n2) Console.WriteLine("Hanyang");
            }