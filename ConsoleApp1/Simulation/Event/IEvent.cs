public interface IEventDefinition
{
    public float GetPawnDesireToPerform(IPawn pawn);
    public IEvent CreateEvent(RandomGenerator randomGenerator, IPawn performer);
}
public interface IEvent
{
    public List<IAction> Perform(RandomGenerator randomGenerator);
    public string GetEventDescription();
    
}