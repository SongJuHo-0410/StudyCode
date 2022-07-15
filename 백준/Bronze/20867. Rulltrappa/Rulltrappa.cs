string[] msg = Console.ReadLine().Split(' ');
            double m = double.Parse(msg[0]); //총 계단 수
            double s = double.Parse(msg[1]); //가만히 있을 떄 1초에 올라가는 계단 수
            double g = double.Parse(msg[2]); //걸어서 올라갈 때 1초에 올라가는 계단 수

            string[] ab = Console.ReadLine().Split(' ');
            double a = double.Parse(ab[0]); //g 1초마다 올라갈 수 있는 사람 수
            double b = double.Parse(ab[1]); //s 1초마다 올라갈 수 있는 사람 수

            string[] lr = Console.ReadLine().Split(' ');
            double l = double.Parse(lr[0]); //L현재 줄
            double r = double.Parse(lr[1]); //R현재 줄

            double ms = m, mg = m;

            ms = (r / b) + (m / s); //오른쪽
            mg = (l / a) + (m / g); //왼쪽

            if (ms > mg) Console.WriteLine("friskus");
            else if (ms < mg) Console.WriteLine("latmask");