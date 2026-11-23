public class NullEventDefinition : IEventDefinition
{
    public IEvent CreateEvent(RandomGenerator randomGenerator, IPawn performer)
    {
        return new NullEvent();
    }

    public float GetPawnDesireToPerform(IPawn pawn)
    {
        return 0;
    }
}
public class NullEvent : IEvent
{
    public string GetEventDescription()
    {
        return "nullevent";
    }

    public List<IAction> Perform(RandomGenerator randomGenerator)
    {
        return new List<IAction>{};
    }
    
}