using System;
using System.ComponentModel;

while (true)
{
    string s = Console.ReadLine();
    string[] ss = s.Split(' ');
    string[] s1 = ss[0].Split(':');
    int sh = int.Parse(s1[0]);
    int sm = int.Parse(s1[1]);
    string[] s2 = ss[1].Split(':');
    int eh = int.Parse(s2[0]);
    int em = int.Parse(s2[1]);
    if (sh + sm + eh + sm == 0) break;

    TimeSpan startTime = new TimeSpan(sh, sm, 0);
    TimeSpan addTime = new TimeSpan(eh, em, 0);
    TimeSpan endTime = startTime.Add(addTime);
    if (endTime.Days > 0)
    {
        string result = endTime.ToString("hh':'mm' +'d");
        Console.WriteLine(result);
    }
    if (endTime.Days == 0)
    {
        string result = endTime.ToString("hh':'mm");
        Console.WriteLine(result);
    }
}
