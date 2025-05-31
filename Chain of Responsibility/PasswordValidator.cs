// الكلاس الأساسي Handler
// كائن الطلب
// معالج التحقق من البريد الإلكتروني
// معالج التحقق من كلمة المرور
class PasswordValidator : Handler
{
    public override void Handle(Request request)
    {
        if (request.Password.Length < 6)
        {
            Console.WriteLine("Password is so smaller.");
        }
        else
        {
            Console.WriteLine("Password is success.");
            next?.Handle(request);
        }
    }
}
