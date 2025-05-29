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
class BasicWheat : IBurger
{
    public void Prepare()
    {
        System.Console.WriteLine("Preparing a basic wheat burger");
    }
}
class StandardWheat : IBurger
{
    public void Prepare()
    {
        System.Console.WriteLine("preparing a standard wheat burger");
    }
}
class PremiumWheat : IBurger
{
    public void Prepare()
    {
        System.Console.WriteLine("preparing a premium wheat burger");
    }
}


interface IBurgerfactory
{
    public IBurger Createburger(string type);


}
class SinghBurger : IBurgerfactory
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
class KingBurger : IBurgerfactory 
{
    public IBurger Createburger(string type)
    {
        if (type == "Basic")
        {
            return new BasicWheat();
        }
        else if (type == "Standard")
        {
            return new StandardWheat();
        }
        else if (type == "Premium")
        {
            return new PremiumWheat();

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
        IBurgerfactory factory = new KingBurger();
        IBurger burger = factory.Createburger("Basic");
        burger.Prepare();
    }
}