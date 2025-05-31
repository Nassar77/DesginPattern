// الواجهة العامة لأي خصم
class Program
{
    static void Main()
    {
        decimal total = 100m;

        // عميل طالب
        ShoppingCart cart1 = new ShoppingCart(new StudentDiscount());
        Console.WriteLine("🎓 Student Checkout:");
        cart1.Checkout(total);

        // عميل متقاعد
        ShoppingCart cart2 = new ShoppingCart(new SeniorDiscount());
        Console.WriteLine("\n👴 Senior Checkout:");
        cart2.Checkout(total);

        // عميل موظف
        ShoppingCart cart3 = new ShoppingCart(new NoDiscount());
        Console.WriteLine("\n💼 Employee Checkout:");
        cart3.Checkout(total);
    }
}
