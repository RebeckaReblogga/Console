public class HoldDinnerPartyEventDefinition : PawnEventDefinition
{
    public HoldDinnerPartyEventDefinition(SimulationState simulationState, float baseDesireability) : base(simulationState, baseDesireability)
    {
    }

    public override IEvent CreateEvent(RandomGenerator randomGenerator, IPawn performer)
    {
        //figure out which attendants want to join
        List<IPawn> attendants = new List<IPawn>{};
        //create and return the event

        string description = performer.GetName() + " held a dinner party";

        return new HoldDinnerPartyEvent(description, attendants, performer);
        
    }    
}
public class HoldDinnerPartyEvent : EventWithDescription
{
    List<IPawn> attendants;
    IPawn performer;

    public HoldDinnerPartyEvent(string description, List<IPawn> attendants, IPawn performer) : base(description)
    {
        this.attendants = attendants;
        this.performer = performer;
    }

    public override List<IAction> Perform(RandomGenerator randomGenerator)
    {
        List<IAction> actionList = new List<IAction>{};

        foreach(IPawn attendant in attendants) //the change in relationship should probably instead be slightly random and also it should be between all of the attendants too
        {
            float relationChange = randomGenerator.GetRandomNumberSingle(-0.5f, 1f);
            actionList.Add(new RelationScoreChangeAction(performer, attendant, relationChange));
        }

        return actionList;
    }
}