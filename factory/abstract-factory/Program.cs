interface IBurger
{
    void Prepare();
}
interface IGarlicbread
{
    void prepare();
}
class Basicburuger : IBurger
{
    public void Prepare()
    {
        System.Console.WriteLine("Preparing a basic burger");
    }
}
class Standardburger : IBurger
{
    public void Prepare()
    {
        System.Console.WriteLine("preparing a standard burger");
    }
}
class Premiumburger : IBurger
{
    public void Prepare()
    {
        System.Console.WriteLine("preparing a premium burger");
    }
}
class BasicWheatburger : IBurger
{
    public void Prepare()
    {
        System.Console.WriteLine("Preparing a basic wheat burger");
    }
}
class StandardWheatburger : IBurger
{
    public void Prepare()
    {
        System.Console.WriteLine("preparing a standard wheat burger");
    }
}
class PremiumWheatburger : IBurger
{
    public void Prepare()
    {
        System.Console.WriteLine("preparing a premium wheat burger");
    }
}
class Basicgarlicbread : IGarlicbread
{
    public void prepare()
    {
        System.Console.WriteLine("preparing a basic garlic bread");
    }
}
class Cheesegarlicbread : IGarlicbread
{
    public void prepare()
    {
        System.Console.WriteLine("preparing a cheese garlic bread");
    }
}
class Basicwheatgarlicbread : IGarlicbread
{
    public void prepare()
    {
        System.Console.WriteLine("preparing a basic wheat garlic bread");
    }
}
class Cheesewheatgarlicbread : IGarlicbread
{
    public void prepare()
    {
        System.Console.WriteLine("preparing a cheese wheat garlic bread");
    }
}

interface IMealfactory
{
    public IBurger Createburger(string type);
    public IGarlicbread Creategarlicbread(string type);


}
class SinghBurger : IMealfactory
{
    public IBurger Createburger(string type)
    {
        if (type == "Basic")
        {
            return new Basicburuger();
        }
        else if (type == "Standard")
        {
            return new Standardburger();
        }
        else if (type == "Premium")
        {
            return new Premiumburger();

        }
        else
        {
            throw new ArgumentException("Burger type not available");
        }
    }
    public IGarlicbread Creategarlicbread(string type)
    {
        if (type == "Basic")
        {
            return new Basicgarlicbread();
        }
        else if (type == "Standard")
        {
            return new Cheesegarlicbread();
        }
        else
        {
            throw new ArgumentException("Burger type not available");
        }
    }
}
class KingBurger : IMealfactory
{
    public IBurger Createburger(string type)
    {
        if (type == "Basic")
        {
            return new BasicWheatburger();
        }
        else if (type == "Standard")
        {
            return new StandardWheatburger();
        }
        else if (type == "Premium")
        {
            return new PremiumWheatburger();

        }
        else
        {
            throw new ArgumentException("Burger type not available");
        }
    }
    public IGarlicbread Creategarlicbread(string type)
    {
        if (type == "Basic")
        {
            return new Basicwheatgarlicbread();
        }
        else if (type == "Standard")
        {
            return new Cheesewheatgarlicbread();
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
        IMealfactory factory = new KingBurger();
        IMealfactory factory1 = new SinghBurger();
        IGarlicbread garlicbread = factory1.Creategarlicbread("Standard");
        IBurger burger = factory.Createburger("Basic");
        burger.Prepare();
        garlicbread.prepare();
    }
}