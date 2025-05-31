namespace Chain_of_Responsibility;
class RoleValidator : Handler
{
    public override void Handle(Request request)
    {
        if (request.Role != "Admin")
        {
            Console.WriteLine("Not Authorized for you.");
        }
        else
        {
            Console.WriteLine("Authorized.");
        }
    }
}
