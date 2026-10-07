namespace leetcode;

public class Solution322 
{
    public int CoinChange(int[] coins, int amount) 
    {
        
        if(amount == 0)
        {
            return 0;
        }

        int depth = 0;

        var res = new HashSet<int>() { amount };
        var v = new HashSet<int>() { amount };

        while(res.Count > 0)
        {
            depth++;

            var hs = new HashSet<int>();
            foreach (var e in res)
            {
                for (int i = 0; i < coins.Length; i++)
                {
                    int value = e - coins[i];

                    if (value == 0)
                        return depth;

                    if (value > 0 && !v.Contains(value))
                    {
                        v.Add(value);
                        hs.Add(value);
                    }
                }
            }

            res = hs;
        }

        return -1;
    }
}