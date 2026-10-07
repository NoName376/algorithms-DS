namespace leetcode;

public class Solution22
{
    public IList<string> GenerateParenthesis(int n)
    {
        var prev = new HashSet<string>() { "()" };
        var curr = new HashSet<string>();

        if (n == 1)
        {
            return prev.ToList();
        }
        
        for (var i = 1; i < n; i++)
        {
            curr.Clear();
            
            foreach (var c in prev)
            {
                for (var j = 0; j <= c.Length; j++)
                {
                    curr.Add(c.Insert(j, "()"));
                }
            }
            
            prev = curr.ToHashSet();
        }
        
        return curr.ToList();
    }
}