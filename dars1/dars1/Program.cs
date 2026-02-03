namespace dars1;

internal class Program
{
    static void Main(string[] args)
    {
        MyList myList = new MyList(3);
        myList.Add(77);
        myList.Add(71);
        myList.Add(73);
        myList.Add(75);
        myList.Add(77);
        myList.RemoveAll(77);
        myList.DisplayElements();
    }
}
