public abstract class PawnEventDefinition : IEventDefinition
{
    protected SimulationState simulationState;
    protected List<IAspectEventInfluence> aspectEventInfluences;
    float baseDesireability;
    protected RandomGenerator randomGenerator;

    protected PawnEventDefinition(SimulationState simulationState, List<IAspectEventInfluence> aspectEventInfluences, float baseDesireability)
    {
        this.simulationState = simulationState;
        this.aspectEventInfluences = aspectEventInfluences;
        this.baseDesireability = baseDesireability;
        this.randomGenerator = simulationState.randomGenerator;
    }

    public abstract IEvent CreateEvent(RandomGenerator randomGenerator, IPawn performer);
    public virtual float GetPawnDesireToPerform(IPawn pawn)
    {
        return baseDesireability + ApplyInfluences(pawn);
    }
    public float ApplyInfluences(IPawn pawn)
    {
        float delta = 0;
        foreach(IAspectEventInfluence influence in aspectEventInfluences)
        {
            if (pawn.HasAspect(influence.GetAspect()))
            {
                delta += influence.GetInfluence();
            }
        }
        return delta;
    }
}