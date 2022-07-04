            using System.Text;
            int num = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                    string[] text = Console.ReadLine().Split();
                    int a = int.Parse(text[0]);
                    int b = int.Parse(text[1]);
                    sb.Append((a + b) + "\n");
            }
            Console.WriteLine(sb);