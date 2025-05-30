interface ISubject
{
    public void Registerobserver(IObserver o);
    public void Removeobserver(IObserver o);
    public void NotifyObserver();
}
interface IObserver {
    void Update(float temp, float humidity, float pressure);
}
interface IDisplay {
    void Display();
}
class Weatherdata : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private float temp;
    private float humidity;
    private float pressure;
    public void Registerobserver(IObserver o)
    {
        observers.Add(o);
    }
    public void Removeobserver(IObserver o)
    {
        observers.Remove(o);
    }
    public void NotifyObserver()
    {
        foreach (var observer in observers)
        {
            observer.Update(temp, humidity, pressure);
        }
    }
    public void Measurementschange()
    {
        NotifyObserver();
    }
    public void Setmeasurements(float temp, float humidity, float pressure)
    {
        this.temp = temp;
        this.humidity = humidity;
        this.pressure = pressure;
        Measurementschange();
    }

}
class currentconditions : IObserver, IDisplay
{
    private float temp;
    private float humidity;
    public void Update(float temp, float humidity, float pressure)
    {
        this.temp = temp;
        this.humidity = humidity;
        Display();
    }
    public void Display()
    {
        System.Console.WriteLine($"temperature:{temp} humidity{humidity}");
    }
}
class Program
{
    static void Main()
    {
        Weatherdata weatherdata = new Weatherdata();
       
        currentconditions currentconditions = new currentconditions();
        currentconditions currentconditions1 = new currentconditions();
        weatherdata.Registerobserver(currentconditions);
        weatherdata.Registerobserver(currentconditions1);
        weatherdata.Removeobserver(currentconditions1);
        weatherdata.Setmeasurements(2, 5.6f, 6.7f);
        currentconditions.Display();
    }
}