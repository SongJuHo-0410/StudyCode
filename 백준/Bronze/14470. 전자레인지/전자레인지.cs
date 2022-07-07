int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int sec = 0;
            if(a < 0)
            {
                while(a < 0)
                {
                    a++;
                    sec += c;
                }
            }
            if (a == 0)
            {
                sec += d;
            }
            if (a <= b)
            {
                while (a < b)
                {
                    a++;
                    sec += e;
                    
                }
                
            }
            Console.WriteLine(sec);