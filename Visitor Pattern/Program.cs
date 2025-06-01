class Program
{
    static void Main()
    {
        List<IItemElement> items = new List<IItemElement>
        {
            new Book("Design Patterns", 50),
            new DVD("Inception", 20)
        };

        var printVisitor = new PrintVisitor();
        var costVisitor = new CostVisitor();

        foreach (var item in items)
        {
            item.Accept(printVisitor);
            item.Accept(costVisitor);
        }

        Console.WriteLine($"Total Cost: {costVisitor.TotalCost}");
    }
}
