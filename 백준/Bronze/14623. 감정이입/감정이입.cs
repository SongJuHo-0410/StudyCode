string a = Console.ReadLine();
            string b = Console.ReadLine();
            long an = Convert.ToInt32(a, 2);
            long bn = Convert.ToInt32(b, 2);

            Console.WriteLine(Convert.ToString(an*bn, 2));