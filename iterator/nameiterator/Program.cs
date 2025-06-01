class NameCollection
{
    private string[] names = { "ram", "hari", "shyam" };
    public NameIterator GetIterator()
    {
        return new NameIterator(names);
    }
}
class NameIterator {
    private string[] _names;
    private int _position = 0;
    public NameIterator(string[] names)
    {
        _names = names;
    }
    public bool Hasnext()
    {
        return _position < _names.Length;
    }
    public string Next()
    {
        return _names[_position++];
    }
}
class Program {
    static void Main()
    {
        NameCollection nameCollection = new NameCollection();
        NameIterator nameIterator = nameCollection.GetIterator();
        while (nameIterator.Hasnext())
        {
            System.Console.WriteLine(nameIterator.Next());
        }

    }
}