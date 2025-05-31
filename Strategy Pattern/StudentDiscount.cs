// الواجهة العامة لأي خصم
class StudentDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount)
    {
        return amount * 0.90m; // خصم 10%
    }
}
