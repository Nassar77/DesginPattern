
// Originator: Represents the Player (Tommy Vercetti)
class Player
{
    public string Location { get; set; } = string.Empty;
    public int Money { get; set; }
    public string Weapons { get; set; } = string.Empty;

    public void ShowStatus()
    {
        Console.WriteLine($" Location: {Location},  Money: ${Money},  Weapons: {Weapons}");
    }

    // Save current state
    public Memento SaveState()
    {
        Console.WriteLine(" Game saved...");
        return new Memento(Location, Money, Weapons);
    }

    // Restore a saved state
    public void RestoreState(Memento memento)
    {
        Location = memento.Location;
        Money = memento.Money;
        Weapons = memento.Weapons;
        Console.WriteLine(" Game state restored!");
    }
}
