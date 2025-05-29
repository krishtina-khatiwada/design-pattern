class Report
{
    public string Title;
    public string Body;
    public int Sno;
    public override string ToString()
    {
        return $"Sno: {Sno}, Title: {Title}, Body: {Body}";
    }

}
class Reportbuilder
{
    private Report report = new Report();
    public Reportbuilder Addtitle(string title)
    {
        report.Title = title;
        return this;
    }
    public Reportbuilder AddBody(string body)
    {
        report.Body = body;
        return this;
    }
    public Reportbuilder AddSno(int sno)
    {
        report.Sno = sno;
        return this;
    }
    public Report build()
    {
        return report;
    }
}
class Program
{
    static void Main()
    {
        var builder = new Reportbuilder();
        Report newreport = builder
        .Addtitle("this is a newreport")
        .AddBody("today is Wednesday")
        .AddSno(15)
        .build();
        Console.WriteLine(newreport);
    }
}