namespace leetcode;

public class Solution1798 {
    public int GetMaximumConsecutive(int[] coins) 
    {
        Array.Sort(coins);
        
        int prevImp = (coins[0] == 1) ? 2 : 1;

        for (int i = 1; i < coins.Length; i++)
        {
            if (prevImp >= coins[i])
            {
                prevImp += coins[i];
            }
            else
            {
                break;
            }
        }
        
        return prevImp;
    }
}