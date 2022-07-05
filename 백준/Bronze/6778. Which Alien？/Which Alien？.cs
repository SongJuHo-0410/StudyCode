            int i = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            if(i > 2 && e < 5)
            {
                Console.WriteLine("TroyMartian");
                if (i < 7 && e > 1)
                {
                    Console.WriteLine("VladSaturnian");
                }
                else if(i < 3 && e < 4)
                {
                    Console.WriteLine("GraemeMercurian");
                }
            }
            else if(i < 7 && e > 1)
            {
                Console.WriteLine("VladSaturnian");
                if(i < 3 && e < 4)
                {
                    Console.WriteLine("GraemeMercurian");
                }
            }
            else if(i < 3 && e < 4)
            {
                Console.WriteLine("GraemeMercurian");
            }