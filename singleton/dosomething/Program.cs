class Singleton
{
    private static Singleton instance;
    private Singleton() { }
    public static Singleton Getinstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
    public void Dosomething()
    {
        Console.WriteLine("insantation through a singleton");
    }
}
class Program
{
    static void Main()
    {
        Singleton ab = Singleton.Getinstance();
        ab.Dosomething();
    }
    
}