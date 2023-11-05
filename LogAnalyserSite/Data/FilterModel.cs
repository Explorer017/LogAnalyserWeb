namespace LogAnalyserSite.Data;

public class FilterModel
{
    public bool debugFilter = true;
    public bool infoFilter = true;
    public bool warnFilter = true;
    public bool errorFilter = true;
    public bool otherFilter = true;
    public bool critFilter = true;
    public string searchFilter = "";
    public bool regex = false;

    public FilterModel()
    {

    }
}