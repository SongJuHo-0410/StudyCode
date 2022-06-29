            string a = Console.ReadLine();
            string ch = "";
            for (int i = 0; i < a.Length; i++)
            {
               if(Char.IsUpper(a[i]))
                {
                    ch = a[i].ToString();
                    Console.Write(ch.ToLower());
                }
                else
                {
                    ch = a[i].ToString();
                    Console.Write(ch.ToUpper());
                }
            }
