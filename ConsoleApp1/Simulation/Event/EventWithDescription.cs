public abstract class EventWithDescription : IEvent
{
    protected string description;

    protected EventWithDescription(string description)
    {
        this.description = description;
    }

    public string GetEventDescription()
    {
        return description;
    }
    public abstract List<IAction> Perform(RandomGenerator randomGenerator);
}