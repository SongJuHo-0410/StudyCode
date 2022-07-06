int ori = int.Parse(Console.ReadLine());
            int now = int.Parse(Console.ReadLine());
            if (ori > now || ori == now)
            {
                Console.WriteLine("Congratulations, you are within the speed limit!");
            }
            else if ((ori + 20) > now || ori + 20 == now)
            {
                Console.WriteLine("You are speeding and your fine is $100.");
            }
            else if ((ori + 30) > now || ori + 30 == now)
            {
                Console.WriteLine("You are speeding and your fine is $270.");
            }
            else if ((ori + 30) < now)
            {
                Console.WriteLine("You are speeding and your fine is $500.");
            }