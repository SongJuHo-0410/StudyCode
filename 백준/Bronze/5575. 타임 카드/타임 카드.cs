for (int i = 0; i < 3; i++)
            {
                string[] time = Console.ReadLine().Split();
                TimeSpan first = new TimeSpan(int.Parse(time[0]), int.Parse(time[1]), int.Parse(time[2]));
                TimeSpan second = new TimeSpan(int.Parse(time[3]), int.Parse(time[4]), int.Parse(time[5]));
                TimeSpan answer = second.Subtract(first);
                Console.WriteLine(answer.Hours + " " + answer.Minutes + " " + answer.Seconds);

            }