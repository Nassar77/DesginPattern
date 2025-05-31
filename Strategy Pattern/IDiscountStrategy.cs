// الواجهة العامة لأي خصم
interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal amount);
}
