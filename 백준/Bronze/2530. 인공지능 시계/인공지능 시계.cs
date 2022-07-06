string[] input = Console.ReadLine().Split();
            int num = int.Parse(Console.ReadLine());
            int hour = int.Parse(input[0]);
            int min = int.Parse(input[1]);
            int sec = int.Parse(input[2]);

            TimeSpan today = new TimeSpan(hour,min,sec);
            TimeSpan duration = new TimeSpan(0, 0, num);
            TimeSpan answer = today.Add(duration);
            Console.WriteLine(answer.Hours + " " + answer.Minutes + " " + answer.Seconds);