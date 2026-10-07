namespace leetcode;

public class Solution55 
{
    public bool CanJump(int[] nums) 
    {
        var dp = new bool[nums.Length];

        dp[0] = true;

        for (int i = 1; i < nums.Length; i++)
        {
            dp[i] = false;
            
            for (int j = i - 1; j >= 0; j--)
            {
                if(dp[j] && nums[j] >= i - j)
                    dp[i] = true;
            }
        }
        
        
        return dp[^1];
    }
}