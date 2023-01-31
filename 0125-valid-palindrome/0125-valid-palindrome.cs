using System.Text.RegularExpressions;
public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return true;
        Regex rgx = new("[^a-z0-9]");
        s = rgx.Replace(s.ToLower(), "");
        int i = 0;
        int j = s.Length - 1;
        for (; i < s.Length / 2; i++, j--)
        {
            char ch1 = s[i];
            char ch2 = s[j];
            if (ch1 != ch2) return false;
        }
        return true;
    }
}
/*
 Time complexity  = O(n)
*/