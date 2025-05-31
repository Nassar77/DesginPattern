
// Memento: Stores the state
class Memento
{
    public string Location { get; }
    public int Money { get; }
    public string Weapons { get; }

    public Memento(string location, int money, string weapons)
    {
        Location = location;
        Money = money;
        Weapons = weapons;
    }
}
