interface IBurger
{
    void Prepare();
}
class Basic : IBurger
{
    public void Prepare()
    {
        System.Console.WriteLine("Preparing a basic burger");
    }
}
class Standard : IBurger
{
    public void Prepare()
    {
        System.Console.WriteLine("preparing a standard burger");
    }
}
class Premium : IBurger
{
    public void Prepare()
    {
        System.Console.WriteLine("preparing a premium burger");
    }
}
class Burgerfactory
{
    public IBurger Createburger(string type)
    {
        if (type == "Basic")
        {
            return new Basic();
        }
        else if (type == "Standard")
        {
            return new Standard();
        }
        else if (type == "Premium")
        {
            return new Premium();

        }
        else
        {
            throw new ArgumentException("Burger type not available");
        }
    }
}
class Program
{
    static void Main()
    {
        var factory = new Burgerfactory();
        IBurger burger = factory.Createburger("Basic");
        burger.Prepare();
    }
}