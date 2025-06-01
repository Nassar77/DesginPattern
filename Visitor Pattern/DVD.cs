// Element interface
// Visitor interface
public class DVD : IItemElement
{
    public string Name { get; set; }
    public double Price { get; set; }

    public DVD(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
