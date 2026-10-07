namespace leetcode;

class Program
{
    static void Main(string[] args)
    {
        var s = new Solution22();
        
        Console.WriteLine(string.Join(", ", s.GenerateParenthesis(3)));
    }
}