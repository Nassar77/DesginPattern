// الواجهة العامة لأي خصم
class SeniorDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount)
    {
        return amount * 0.80m; // خصم 20%
    }
}
