while (true)
            {
                int leaves = 1;
                string[] s = Console.ReadLine().Split();
                if (s[0] == "0") break;
                
                for (int i = 1; i <= int.Parse(s[0]); i++)
                {
                    leaves = leaves * int.Parse(s[i*2-1]) - int.Parse(s[i*2]);
                    
                }
                Console.WriteLine(leaves);
            }