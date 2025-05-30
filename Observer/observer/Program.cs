interface IObserver
{
    public void Update(string message);
}
class Observable
{
    private List<IObserver> observers = new List<IObserver>();
    private string message;
    public void Add(IObserver observer)
    {
        observers.Add(observer);
    }
    public void Remove(IObserver observer)
    {
        observers.Remove(observer);
    }
    public void notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
    public void changemessage(string newmessage)
    {
        message = newmessage;
        notify();
    }

}
class Concreteobserver : IObserver
{
    public void Update(string message)
    {
        System.Console.WriteLine("update message recieved"+ message);
    }
}
class Program
{
    static void Main()
    {
        Observable obs = new Observable();
        Concreteobserver con = new Concreteobserver();
        obs.Add(con);
        obs.changemessage("new feature added");

    }
}