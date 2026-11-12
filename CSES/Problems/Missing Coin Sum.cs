namespace CSES;

public class Solution2183
{
    public int SmallestCoinSum(int[] nums)
    {
        Array.Sort(nums);
        
        Console.WriteLine(string.Join(", ", nums));
        
        int prevImp = (nums[0] == 1) ? 2 : 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (prevImp >= nums[i])
            {
                prevImp += nums[i];
            }
            else
            {
                break;
            }
        }
        
        return prevImp;
    }
}