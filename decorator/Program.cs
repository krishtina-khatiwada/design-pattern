interface IMario
{
    string Getabilities();
}
class PlainMario : IMario
{
    public string Getabilities()
    {
        return "Mario";
    }
}
class MarioDecorator : IMario
{
    protected IMario mario;
    public MarioDecorator(IMario mario)
    {
        this.mario = mario;
    }
    public virtual string Getabilities()
    {
    return mario.Getabilities();
    }
}

class SuperMario : MarioDecorator
{
    public SuperMario(IMario mario) : base(mario) { }
    public override string Getabilities()
    {
        return base.Getabilities() + " Big size ";
    }
}
class WithGUN : MarioDecorator
{
    public WithGUN(IMario mario) : base(mario) { }
    public override string Getabilities()
    {
        return base.Getabilities() + " With Gun ";
    }
}
class Flower : MarioDecorator {
    public Flower (IMario mario) : base(mario) { }
    public override string Getabilities()
    {
        return base.Getabilities() + " has flower ";
    }
}
class Program {
    static void Main()
    {
        IMario mario = new PlainMario();
        mario = new SuperMario(mario);
        mario = new Flower(mario);
        mario = new WithGUN(mario);
        System.Console.WriteLine(mario.Getabilities());
    }
}