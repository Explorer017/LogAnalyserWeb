namespace LogAnalyserSite.Data;

public class LogLine
{
    public string date { get; private set; }
    public string time { get; private set; }
    public Type type { get; private set; }
    public string message { get; private set; }

    public LogLine(string date, string time, Type type, string message )
    {
        this.date = date;
        this.time = time;
        this.type = type;
        this.message = message;
    }

}