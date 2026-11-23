public class HoldSpeechEventDefinition : PawnEventDefinition
{
    public HoldSpeechEventDefinition(SimulationState simulationState, List<IAspectEventInfluence> aspectEventInfluences, float baseDesireability) : base(simulationState, aspectEventInfluences, baseDesireability){}
    public override IEvent CreateEvent(RandomGenerator randomGenerator, IPawn performer)
    {
        string description = performer.GetName() + " held a speech";
        return new HoldSpeechEvent(description);
    }
}
public class HoldSpeechEvent : EventWithDescription
{
    public HoldSpeechEvent(string description) : base(description){}

    public override List<IAction> Perform(RandomGenerator randomGenerator)
    {
        return new List<IAction>{};
    }
    
}