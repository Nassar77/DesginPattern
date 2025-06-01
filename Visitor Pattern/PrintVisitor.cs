// Element interface
// Visitor interface
public class PrintVisitor : IVisitor
{
    public void Visit(Book book)
    {
        Console.WriteLine($"Book: {book.Title}, Price: {book.Price}");
    }

    public void Visit(DVD dvd)
    {
        Console.WriteLine($"DVD: {dvd.Name}, Price: {dvd.Price}");
    }
}
