class Coffee : HotBeverage
{
    protected override void Brew()
    {
        Console.WriteLine("☕ Brewing the coffee grounds...");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("🧂 Adding sugar and milk...");
    }
}
