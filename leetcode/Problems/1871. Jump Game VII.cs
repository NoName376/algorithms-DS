namespace leetcode;

public class Solution1871 
{
    public bool CanReach(string s, int minJump, int maxJump) 
    {
        var dp = new bool[s.Length];

        dp[0] = true;

        var jc = 0;
        
        for (int i = 1; i < s.Length; i++)
        {
            dp[i] = false;
            
            var ri = i - minJump;
            if (ri >= 0 && dp[ri])
                jc++;
            
            int li = i - maxJump - 1;
            if (li >= 0 && dp[li])
                jc--;

            if (s[i] == '0' && jc > 0)
                dp[i] = true;
        }
        
        
        return dp[^1];
    }
}