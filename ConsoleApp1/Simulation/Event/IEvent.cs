public interface IEvent
{
    public ISimulation Perform(ISimulation simulationState);
    public float GetPawnDesireToPerform(IPawn pawn);
}