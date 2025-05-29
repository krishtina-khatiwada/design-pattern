class Singleton
{
    private static readonly Lazy<Singleton> lazyinstance= new Lazy<Singleton>(() => new Singleton());
    private Singleton() { }
    public static Singleton Getinstance()
    {
        return lazyinstance.Value;
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