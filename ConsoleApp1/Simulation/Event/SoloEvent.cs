public abstract class SoloEvent : IEvent
{
    protected IPawn performer;

    protected SoloEvent(IPawn performer)
    {
        this.performer = performer;
    }

    public abstract float GetPawnDesireToPerform(IPawn pawn);
    public abstract ISimulation Perform(ISimulation simulationState);
}