namespace dars10;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<Book, string> books = new Dictionary<Book, string>();

        //Book book1 = new Book { Name = "Harry Potter Philosofer Stone", Author = "J.K.Rowling", Year = "1997" };
        //Book book2 = new Book { Name = "Harry Potter Prisener ofAzhaban ", Author = "J.K.Rowling", Year = "2000" };
        //Book book3 = new Book { Name = "Harry Potter Chamber of Secrets", Author = "J.K.Rowling", Year = "1999" };

        //books.Add(book1,"J.K.Rowling");
        //books.Add(book2, "J.K.Rowling");
        //books.Add(book3, "J.K.Rowling");
        //Console.WriteLine(books.Values);

        Stack<int> ints = new Stack<int>();
        ints.Push(1);
        ints.Push(2);
        ints.Push(3);
        ints.Push(4);
        ints.Push(5);
        Console.WriteLine(ints.Pop());
        Console.WriteLine(ints.Pop());
        Console.WriteLine(ints.Pop());
        Console.WriteLine(ints.Pop());
        Console.WriteLine(ints.Pop());
    }
}
