
 class Singleton
{
    private static Singleton instance;
     private static readonly object lockObj = new object();
    private Singleton() { }
    public static Singleton Getinstance()
    {
        lock (lockObj)
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
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