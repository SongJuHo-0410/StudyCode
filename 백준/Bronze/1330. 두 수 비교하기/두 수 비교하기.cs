            String[] all = Console.ReadLine().Split();
            var a = int.Parse(all[0]);
            var b = int.Parse(all[1]);
            if (a > b) 
            {
                Console.WriteLine(">");
            }
            else if(a < b)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }