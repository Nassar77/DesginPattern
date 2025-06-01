// Element interface
// Visitor interface
// Visitor for calculating total cost
public class CostVisitor : IVisitor
{
    public double TotalCost { get; private set; }

    public void Visit(Book book)
    {
        TotalCost += book.Price;
    }

    public void Visit(DVD dvd)
    {
        TotalCost += dvd.Price;
    }
}
