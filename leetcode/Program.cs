namespace leetcode;

class Program
{
    static void Main(string[] args)
    {
        var s = new Solution167();
        
        Console.WriteLine(string.Join(", ", s.TwoSum([2, 7, 11, 15], 9)));
    }
}