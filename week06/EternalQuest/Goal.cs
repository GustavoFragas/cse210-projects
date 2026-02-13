public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string Name
    {
        get { return _shortName; }
    }

    public string Description
    {
        get { return _description; }
    }

    public int Points
    {
        get { return _points; }
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();

    
}