class ListIterator<T> : IIterator<T>
{
    private readonly List<T> _collection;
    private int _position = 0;

    public ListIterator(List<T> collection)
    {
        _collection = collection;
    }

    public bool HasNext()
    {
        return _position < _collection.Count;
    }

    public T Next()
    {
        return _collection[_position++];
    }
}
