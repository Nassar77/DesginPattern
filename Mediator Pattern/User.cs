class User
{
    private string _name;
    private IChatMediator _mediator;

    public User(string name, IChatMediator mediator)
    {
        _name = name;
        _mediator = mediator;
    }

    public void Send(string message)
    {
        Console.WriteLine($"{_name} Send: {message}");
        _mediator.SendMessage(message, this);
    }

    public void Receive(string message)
    {
        Console.WriteLine($"{_name} Reseive: {message}");
    }
}
