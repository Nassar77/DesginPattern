// الواجهة العامة لأي خصم
class ShoppingCart(IDiscountStrategy discountStrategy)
{
    private IDiscountStrategy _discountStrategy = discountStrategy;

    public void SetDiscountStrategy(IDiscountStrategy strategy)
    {
        _discountStrategy = strategy;
    }

    public void Checkout(decimal totalAmount)
    {
        decimal finalAmount = _discountStrategy.ApplyDiscount(totalAmount);
        Console.WriteLine($"💰 Final price after discount: {finalAmount} USD");
    }
}
