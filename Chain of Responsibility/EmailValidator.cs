// الكلاس الأساسي Handler
// كائن الطلب
// معالج التحقق من البريد الإلكتروني
class EmailValidator : Handler
{
    public override void Handle(Request request)
    {
        if (string.IsNullOrEmpty(request.Email))
        {
            Console.WriteLine("Email not found or not correct.");
        }
        else
        {
            Console.WriteLine("Email is correct.");
            next?.Handle(request);
        }
    }
}
