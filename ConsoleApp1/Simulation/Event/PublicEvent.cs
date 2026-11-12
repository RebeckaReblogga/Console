public abstract class PublicEvent : IEvent
{
    protected IPawn host;
    protected List<IPawn> attendants;

    protected PublicEvent(IPawn host, List<IPawn> attendants)
    {
        this.host = host;
        this.attendants = attendants;
    }

    public abstract float GetPawnDesireToPerform(IPawn pawn);
    public abstract ISimulation Perform(ISimulation simulationState);
}