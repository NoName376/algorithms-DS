namespace leetcode;

public class Solution5
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        
        var dp = new bool[s.Length, s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            dp[i, i] = true;
        }
        
        int mLen = 1; string palindrome = s[0].ToString();
        for (int i = s.Length - 2; i >= 0; i--)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (i + 1 == j && s[i] == s[j])
                {
                    dp[i, j] = true;
                }
                else if (dp[i + 1, j - 1] && s[j] == s[i])
                {
                    dp[i, j] = true;
                }
                
                if (dp[i,j] && j - i + 1 > mLen)
                {
                    palindrome = s.Substring(i, j - i + 1);
                    mLen = j - i + 1;
                }
            }
        }
        
        return palindrome;
    }
}