public abstract class TargetedEvent : IEvent
{
    protected IPawn performer;
    protected IPawn target;

    protected TargetedEvent(IPawn performer, IPawn target)
    {
        this.performer = performer;
        this.target = target;
    }

    public abstract float GetPawnDesireToPerform(IPawn pawn);

    public abstract ISimulation Perform(ISimulation simulationState);
}