int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            if(month <= 12 && day <= 31)
            {
                if (month == 2 && day == 18) Console.WriteLine("Special");
                else if ((month == 2 && day >= 18) || month >= 3) Console.WriteLine("After");
                else if (month <= 2 ) Console.WriteLine("Before");
            }