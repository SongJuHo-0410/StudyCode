   using System.Numerics;      
BigInteger result = 0;
            for (int i = 0; i < 2; i++)
            {
                string[] input = Console.ReadLine().Split();
                BigInteger n1 = BigInteger.Parse(input[0]);
                BigInteger n2 = BigInteger.Parse(input[1]);
                result += (n1 * n2);
            }

            string[] input1 = Console.ReadLine().Split();
            BigInteger l1 = BigInteger.Parse(input1[0]);
            BigInteger l2 = BigInteger.Parse(input1[1]);
            BigInteger l3 = BigInteger.Parse(input1[2]);

            Console.WriteLine(result * l1 * l2 * l3);