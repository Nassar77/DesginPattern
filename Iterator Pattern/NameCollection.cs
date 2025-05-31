class NameCollection : IAggregate<string>
{
    private List<string> _names = new List<string>();

    public void Add(string name)
    {
        _names.Add(name);
    }

    public IIterator<string> CreateIterator()
    {
        return new ListIterator<string>(_names);
    }
}

