namespace leetcode;

public class Solution2952 
{
    public int MinimumAddedCoins(int[] coins, int target)
    {
        Array.Sort(coins);
        
        int prevImp = 1;
        int ch = 0;
        
        int i = 0;
        while (prevImp <= target)
        {
            
            if (i < coins.Length && coins[i] <= prevImp)
            {
                prevImp += coins[i];
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