abstract class HotBeverage
{
    // Template method
    public void Prepare()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    protected void BoilWater()
    {
        Console.WriteLine("🔥 Boiling water...");
    }

    protected void PourInCup()
    {
        Console.WriteLine("☕ Pouring into cup...");
    }

    // خطوات تختلف من مشروب لآخر
    protected abstract void Brew();
    protected abstract void AddCondiments();
}
