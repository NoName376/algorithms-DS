namespace leetcode;

public class Solution1220 
{
    public int CountVowelPermutation(int n)
    {
        long mod = 1_000_000_000 + 7;

        (long a, long e, long i, long o, long u) alp = (1, 1, 1, 1, 1);
        (long a, long e, long i, long o, long u) prev = (1, 1, 1, 1, 1);
            
        for (int i = 1; i < n; i++)
        {
            alp.a = (prev.e + prev.u + prev.i) % mod;
            alp.e = (prev.a + prev.i) % mod;
            alp.i = (prev.e + prev.o) % mod;
            alp.o = (prev.i) % mod;
            alp.u = (prev.o + prev.i) % mod;

            prev = alp;
        }

        return (int)((alp.a + alp.e + alp.i + alp.o + alp.u) % mod);
    }    
}