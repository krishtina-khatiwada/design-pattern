class Namecollection
{
    private string[] names = { "ram", "hari", "sita" };
    public IEnumerable<string> GetEnumerable()
    {
        foreach (var name in names)
        {
            yield return name;
        }
    }
    
 }
class Program
{
    static void Main()
    {
        Namecollection collection = new Namecollection();
        foreach (var name in collection.GetEnumerable())
        {
            System.Console.WriteLine(name);
        }
    }
 }