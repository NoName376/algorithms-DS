namespace leetcode;

public class Solution45 
{
    public int Jump(int[] nums)
    {
        var dp = new int[nums.Length];

        Array.Fill(dp, Int32.MaxValue);
        
        dp[0] = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if(dp[j] != int.MaxValue && nums[j] >= i - j)
                    dp[i] = Math.Min(dp[i] ,dp[j] + 1);
            }
        }
        
        
        return dp[^1];
    }
}