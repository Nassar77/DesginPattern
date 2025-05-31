// الواجهة العامة لأي خصم
class NoDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount)
    {
        return amount; // لا يوجد خصم
    }
}
