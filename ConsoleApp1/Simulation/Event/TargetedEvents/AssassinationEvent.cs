public class AssassinationEventDefintion : PawnEventDefinition
{
    public AssassinationEventDefintion(SimulationState simulationState, float baseDesireability) : base(simulationState, baseDesireability)
    {
    }

    public override IEvent CreateEvent(RandomGenerator randomGenerator, IPawn performer)
    {
        IPawn target = new NullPawn();
        //find a suitable target
        IPawn topContender = new NullPawn();
        foreach (IPawn pawn in simulationState.hierarchy.GetAllPawns())
        {
            if(performer.GetOpinionScoreOfPawn(pawn) < performer.GetOpinionScoreOfPawn(topContender))
            {
                topContender = pawn;
            }
        }
        target = topContender;
        if(target is not NullPawn)
        {
            string description = performer.GetName() + " is trying to assassinate " + target.GetName();

            return new AssassinationEvent(description, target);
        }
        return new NullEvent();
    }
}

public class AssassinationEvent : EventWithDescription
{
    IPawn target;

    public AssassinationEvent(string description, IPawn target) : base(description)
    {
        this.target = target;
    }

    public override List<IAction> Perform(RandomGenerator randomGenerator)
    {
        //should probably not always be successful! Instead random chance
        return new List<IAction>{new RemovePawnAction(target)};
    }
    
}