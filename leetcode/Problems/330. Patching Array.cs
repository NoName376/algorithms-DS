namespace leetcode;

public class Solution330 
{
    public int MinPatches(int[] nums, int n) 
    {
        long prevImp = 1;
        int ch = 0;
        
        int i = 0;
        while (prevImp <= n)
        {
            
            if (i < nums.Length && nums[i] <= prevImp)
            {
                prevImp += nums[i];
                i++;
            }
            else
            {
                prevImp *= 2;
                ch++;
            }
        }
        
        return ch;
    }
}