public abstract class PawnEventDefinition : IEventDefinition
{
    protected SimulationState simulationState;
    protected List<IAspectEventInfluence> aspectEventInfluences = new List<IAspectEventInfluence>{};
    float baseDesireability;
    protected RandomGenerator randomGenerator;

    protected PawnEventDefinition(SimulationState simulationState, float baseDesireability)
    {
        this.simulationState = simulationState;
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
    public void AddInfluence(IAspectEventInfluence influence)
    {
        aspectEventInfluences.Add(influence);
    }
    public void AddInfluence(List<IAspectEventInfluence> influences)
    {
        foreach(IAspectEventInfluence influence in influences)
        {
            aspectEventInfluences.Add(influence);
        }
    }
}