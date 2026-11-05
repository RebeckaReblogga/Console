public class ConcretePawn : IPawn
{
    public string pawnName{get; private set;}

    //Feel like we really need to standardize these like very similar scores. They should probably be handled in some more standardized way?
    protected BaseOpinion baseOpinionScore;
    protected IMilitaryPower militaryPowerScore{get;}
    protected float popularityScore; //this could also be made into something more robust than just being a float
    protected List<IEvent> availableEvents;
    protected ICulture culturalReference;
    protected List<IAspect> keyValues; //these are the aspects this pawn cares about the most
    protected List<IAspect> ownedAspects;
    protected IAspect gender;
    protected IHierarchyLevel hierarchyLevel;

    //big constructor
    public ConcretePawn(string pawnName, BaseOpinion baseOpinionScore, IMilitaryPower militaryPowerScore, float popularityScore, List<IEvent> availableEvents, ICulture culturalReference, List<IAspect> keyValues, List<IAspect> ownedAspects, IAspect gender, IHierarchyLevel hierarchyLevel)
    {
        this.pawnName = pawnName;
        this.baseOpinionScore = baseOpinionScore;
        this.militaryPowerScore = militaryPowerScore;
        this.popularityScore = popularityScore;
        this.availableEvents = availableEvents;
        this.culturalReference = culturalReference;
        this.keyValues = keyValues;
        this.ownedAspects = ownedAspects;
        this.gender = gender;
        this.hierarchyLevel = hierarchyLevel;
    }
    //tiny constructor for testing
    public ConcretePawn(string pawnName)
    {
        this.pawnName = pawnName;
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

    public void SetHierarchyLevel(IHierarchyLevel hierarchyLevel)
    {
        this.hierarchyLevel = hierarchyLevel;
    }

    public string GetName()
    {
        return pawnName;
    }
}