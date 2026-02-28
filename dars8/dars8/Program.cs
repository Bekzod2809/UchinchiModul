namespace dars8;


internal class Program
{
    static void Main(string[] args)
    {
        MyList<string> myList = new MyList<string>();
        myList.Add("Hello");
        myList.Add("World");
        myList.DisplayElements();
        MyList<int> myList2 = new MyList<int>();
        myList2.Add(1);
        myList2.Add(2);
        myList2.DisplayElements();
    }
}
