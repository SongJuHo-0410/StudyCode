            int cnt = 0;
            int team = 0;
            for (int i = 0; i < 6; i++)
            {
                string input = Console.ReadLine();
                if(input == "W") cnt++;
            }

            if (cnt > 4) team = 1;
            else if (cnt > 2 && cnt < 5) team = 2;
            else if (cnt > 0 && cnt < 3) team = 3;
            else if (cnt < 1) team = -1;
            Console.WriteLine(team);