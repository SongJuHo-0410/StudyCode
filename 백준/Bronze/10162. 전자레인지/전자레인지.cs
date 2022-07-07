int num = int.Parse(Console.ReadLine());

            int a = 300;
            int b = 60;
            int c = 10;

            int[] n = new int[3];

            n[0] = num / a;
            num -= n[0] * a; 
            n[1] = num / b;
            num -= n[1] * b;
            n[2] = num / c;
            num -= n[2] * c;

            if (num % 10 == 0) Console.WriteLine(n[0] + " " + n[1] + " " + n[2]);
            else if (num % 10 != 0) Console.WriteLine(-1);