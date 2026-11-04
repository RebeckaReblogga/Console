public class ConcretePawn : IPawn
{
    //Feel like we really need to standardize these like very similar scores. They probably be handled in some more standardized way?
    protected BaseOpinion baseOpinionScore;
    protected IMilitaryPower militaryPowerScore{get;}
    protected float popularityScore; //this could also be made into something more robust than just being a float
    protected List<IEvent> availableEvents;
    protected ICulture culturalReference;
    protected List<IAspect> keyValues; //these are the aspects this pawn cares about the most
    protected List<IAspect> ownedAspects;
    protected IAspect gender;

    public ConcretePawn()
    {
        
    }
    public IOpinion GetBaseOpinion()
    {
        return baseOpinionScore;
    }
    public IMilitaryPower GetMilitaryPower()
    {
        return militaryPowerScore;
    }
    public float GetPopularity() //TODO
    {
        return 0;
    }
    public float GetPower() //TODO
    {
        return 0;
    }
}