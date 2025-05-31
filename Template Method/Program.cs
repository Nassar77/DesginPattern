class Program
{
    static void Main()
    {
        Console.WriteLine("=== Preparing Tea ===");
        HotBeverage tea = new Tea();
        tea.Prepare();

        Console.WriteLine("\n=== Preparing Coffee ===");
        HotBeverage coffee = new Coffee();
        coffee.Prepare();
    }
}
