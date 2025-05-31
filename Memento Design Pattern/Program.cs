using System;
using System.Collections.Generic;

// Application
class Program
{
    static void Main()
    {
        Player tommy = new Player
        {
            Location = "Ocean Beach",
            Money = 1000,
            Weapons = "Pistol"
        };

        GameSaver gameSaver = new GameSaver();

        Console.WriteLine(" Initial state:");
        tommy.ShowStatus();

        // Save initial state
        gameSaver.Save(tommy.SaveState());

        // Simulate mission: state changes
        tommy.Location = "Downtown";
        tommy.Money = 500;
        tommy.Weapons = "AK-47";

        Console.WriteLine("\n After mission:");
        tommy.ShowStatus();

        // Load last saved state
        Memento lastSave = gameSaver.LoadLastSave();
        if (lastSave != null)
        {
            tommy.RestoreState(lastSave);
            Console.WriteLine("\n After loading save:");
            tommy.ShowStatus();
        }
        else
        {
            Console.WriteLine(" No saved game found.");
        }
    }
}
