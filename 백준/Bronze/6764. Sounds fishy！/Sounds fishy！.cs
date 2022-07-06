            int n1 = int.Parse(Console.ReadLine()); 
            int n2 = int.Parse(Console.ReadLine()); 
            int n3 = int.Parse(Console.ReadLine()); 
            int n4 = int.Parse(Console.ReadLine()); 
           
            if(n1 > n2 && n2 > n3 && n3 > n4) Console.WriteLine("Fish Diving");
            else if(n1 < n2 && n2 < n3 && n3 < n4) Console.WriteLine("Fish Rising");
            else if(n1 == n2 && n2 == n3 && n3 == n4) Console.WriteLine("Fish At Constant Depth");
            else Console.WriteLine("No Fish");