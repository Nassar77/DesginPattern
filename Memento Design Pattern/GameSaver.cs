
// Caretaker: Manages save/load operations
class GameSaver
{
    private Stack<Memento> saveHistory = new Stack<Memento>();

    public void Save(Memento memento)
    {
        saveHistory.Push(memento);
    }

    public Memento LoadLastSave()
    {
        return saveHistory.Count > 0 ? saveHistory.Pop() : null;
    }
}
