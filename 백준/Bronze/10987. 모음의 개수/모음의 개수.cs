string s = Console.ReadLine();
string[] vowel = { "a", "e", "i", "o", "u" };

int total = 0;

for (int i = 0; i < s.Length; i++)
{
    for (int j = 0; j < vowel.Length; j++)
    {
        if( vowel[j] == s[i].ToString()) total++;
    }
}

Console.WriteLine(total);