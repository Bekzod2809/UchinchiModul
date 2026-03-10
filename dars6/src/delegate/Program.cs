namespace _delegate;

internal class Program
{
    static void Main(string[] args)
    {
        Action<string> printName;
        printName = GetFirst;
        printName += ToLower;
        printName.Invoke("Bekzod");

        Action<int> printInt;
    }
    static void GetFirst(string s)
    {
        if (s.Length > 5)
        {
            Console.WriteLine(s.Substring(0, 5));
        }
        else
        {
            Console.WriteLine(s);
        }
    }
    static void ToLower(string s)
    {
        Console.WriteLine(s.ToLower());
    }
    static void SumOfDigits(int a)
    {
        a = 0;
        for (int i = 0; i < a; i++)
        {
            a = a + a;
        }
    }
}
