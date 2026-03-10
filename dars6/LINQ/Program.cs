namespace LINQ;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var res = nums.Where(a => a < 5).ToList;
        Console.WriteLine(res);
    }
}
