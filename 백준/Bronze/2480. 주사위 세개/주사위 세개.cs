            String[] all = Console.ReadLine().Split();
            var d1 = int.Parse(all[0]);
            var d2 = int.Parse(all[1]);
            var d3 = int.Parse(all[2]);
            var result = 0;
            if(d1==d2 && d2 == d3)
            {
                result = 10000 + d1 * 1000;
            }
            else if (d1 == d2 || d2 == d3 || d1 == d3)
            {
                if(d1 == d2)
                {
                    result = 1000 + d1 * 100;
                }
                else if(d2 == d3)
                {
                    result = 1000 + d2 * 100;
                }
                else if(d1 == d3)
                {
                    result = 1000 + d3 * 100;
                }
            }
            else if (d1 != d2 && d2 != d3 && d1 != d3)
            {
                var max = 0;
                if(d1 < d2 && d2 > d3)
                {
                    max = d2;
                }
                else if(d1 > d2 && d1 > d3)
                {
                    max = d1;
                }
                else if(d3 > d1 && d3 > d2)
                {
                    max = d3;
                }

                result = max * 100;
            }
            Console.WriteLine(result);