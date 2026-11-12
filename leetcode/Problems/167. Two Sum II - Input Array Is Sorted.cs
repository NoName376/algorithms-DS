namespace leetcode;

public class Solution167
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int l = 0, p = numbers.Length - 1;

        while (l < p)
        {
            int sum = numbers[l] + numbers[p];
            if (sum == target) return [l + 1, p + 1];
            else if (sum < target) l++;
            else p--;
        }
        
        return [];
    }
}