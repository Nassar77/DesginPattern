
class Player
{
    public IPlayerState State { get; set; }

    public Player(IPlayerState initialState)
    {
        State = initialState;
    }

    public void Request()
    {
        State.Handle(this);
    }
}
