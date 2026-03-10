namespace dars11;

internal class Program
{
    static void Main(string[] args)
    {
        Node node = NodeService.CreateNode(4);
        var res = GetLengthOfNode(node);
        Console.WriteLine(res);
        var res2 = GetSumOfNode(node);
        Console.WriteLine(res2);
    }
    static int GetLengthOfNode(Node node)
    {
        var counter = 0;
        while (true)
        {
            if (node != null)
            {
                ++counter;
            }
            if (node.Next == null)
            {
                break;
            }
            node = node.Next;
        }
        return counter;
    }
    static int GetSumOfNode(Node node)
    {
        var counter = 0;
        while (true)
        {
            if (node != null)
            {
                counter += node.Value;
            }
            if (node.Next == null)
            {
                break;
            }
            node = node.Next;
        }
        return counter;
    }
    static int CantainsOfNode(Node node)
    {
        
        return 12;
    }
}
