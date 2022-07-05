string[] input = Console.ReadLine().Split();
            string result = "";
            if (int.Parse(input[1]) == 1 || int.Parse(input[1]) == 2) result = "NEWBIE!";
            else if (int.Parse(input[0]) + 1 > int.Parse(input[1]) && int.Parse(input[1]) > 2) result = "OLDBIE!";
            else if (int.Parse(input[0]) < int.Parse(input[1])) result = "TLE!";

            Console.WriteLine(result);