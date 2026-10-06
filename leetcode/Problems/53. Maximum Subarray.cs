namespace leetcode;

public class Solution53 {
    public int MaxSubArray(int[] nums)
    {
        var dp = new int[nums.Length];
        dp[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            dp[i] = Math.Max(nums[i], nums[i] + dp[i-1]);
        }

        return dp.Max();
    }
}