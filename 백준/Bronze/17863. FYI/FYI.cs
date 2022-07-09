string checkNum(string num)
{
    string ans = "";
    if (num[0]-48 == 5 && num[1] - 48 == 5 && num[2] - 48 == 5) ans = "YES";
    else ans = "NO";
    return ans;
}
string num = Console.ReadLine();
Console.WriteLine(checkNum(num));