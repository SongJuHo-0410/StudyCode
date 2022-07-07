string[] input = Console.ReadLine().Split(' ');
                int n1 = int.Parse(input[0]);
                int n2 = int.Parse(input[1]);
                int n3 = int.Parse(input[2]);

                if (n1 == n2 || n2 == n3 || n3 == n1) Console.WriteLine("S");
                else if(n1 == (n2 + n3) || n2 == (n1 + n3) || n3 == (n2 + n1)) Console.WriteLine("S");
                else Console.WriteLine("N");
