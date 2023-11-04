namespace LogAnalyserSite.Data;

public class LogLine
{
    public string dateAndTime { get; private set; }
    public string type { get; private set; }
    public string message { get; private set; }

    public LogLine(string dateAndTime, string type, string message )
    {
        this.dateAndTime = dateAndTime;
        this.type = type;
        this.message = message;
    }

}