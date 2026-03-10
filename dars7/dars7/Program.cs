





namespace dars7;

internal class Program
{
    static void Main(string[] args)
    {
        //Func<int, int, int, int> func1 = (int a, int b, int c) => Math.Max(a, Math.Max(b, c));

        //var act1 = (string str1, string str2) => Console.WriteLine(str1.Length + str2.Length);

        //List<Book> books = new List<Book>
        //{
        //    new Book { name = "The Pragmatic Programmer", price = 39.99m },
        //    new Book { name = "Clean Code", price = 34.50m },
        //    new Book { name = "Design Patterns", price = 45.00m },
        //    new Book { name = "Refactoring", price = 42.75m },
        //    new Book { name = "C# In Depth", price = 29.99m }
        //};

        //Func<List<Book>, List<Book>> funk2 = (List<Book> books) =>
        //{
        //    var expensive = books.OrderBy(b => b.price);
        //    return books;
        //};

        //var act2 = (Book book) =>
        //{
        //    Console.WriteLine(book); ;
        //    book.price *= 10;
        //    Console.WriteLine(book.name);
        //    Console.WriteLine(book.price);
        //};

        //Func<User, string> funk3 = (User user) =>
        //{
        //    if (user.age >= 18)
        //    {
        //        return "Adult";
        //    }
        //    return "Minor";
        //};

        //Action<Car> act3 = (Car car) => Console.WriteLine(2026 - car.year);

        //var funk4 = (List<Product> products) =>
        //{
        //    var cheap = products.MinBy(p => p.Price);
        //    return cheap;
        //};

        //Action<Order> act5 = (Order order) => Console.WriteLine(order.Quantity * order.Price);

        //Func<List<Student>, List<Student>> funk5 = (List<Student> students) =>
        //{
        //    var clever = students.Where(s => s.Grade >= 90);
        //    return clever.ToList();
        //};

        //Action<int, int> act6 = (int a, int b) => Console.WriteLine(Math.Max(a, b));

        //Func<int, bool> funk6 = (int a) =>
        //{
        //    if (a % 2 != 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //};

        //Func<string, string> funk7 = (string str) =>
        //{
        //    var res = str.Reverse().ToString();
        //    return res;
        //};
    }
}
public class User
{
    public string name { get; set; }
    public int age { get; set; }
}

public class Car
{
    public int year { get; set; }
    public string name { get; set; }
}

public class Product
{
    public int Price { get; set; }
    public string Name { get; set; }
}

public class Order
{
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}

public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
}