public class ConcretePawn : IPawn
{
    public string pawnName{get; private set;}

    //Feel like we really need to standardize these like very similar scores. They should probably be handled in some more standardized way?
    protected MilitaryPower militaryPower;
    protected float popularityScore; //this could also be made into something more robust than just being a float
    protected List<PawnEventDefinition> availableEvents;
    protected ICulture culturalReference;
    protected ICulture culturalOpinions;
    protected PersonalEconomy personalEconomy;
    protected IHierarchyLevel hierarchyLevel;
    protected Dictionary<IPawn,float> relationList = new Dictionary<IPawn, float>();
    private Dictionary<AspectCategory,AspectDefinition> aspects = new();
    protected RandomGenerator randomGenerator;

    public ConcretePawn(string pawnName, MilitaryPower militaryPower, float popularityScore, List<PawnEventDefinition> availableEvents, ICulture culturalReference, ICulture culturalOpinions, IHierarchyLevel hierarchyLevel, PersonalEconomy personalEconomy, RandomGenerator randomGenerator)
    {
        this.pawnName = pawnName;
        this.militaryPower = militaryPower;
        this.popularityScore = popularityScore;
        this.availableEvents = availableEvents;
        this.culturalReference = culturalReference;
        this.culturalOpinions = culturalOpinions;
        this.hierarchyLevel = hierarchyLevel;
        this.personalEconomy = personalEconomy;
        this.randomGenerator = randomGenerator;
    }

    public List<AspectDefinition> ownedAspects => aspects.Values.ToList(); 
      
    public MilitaryPower GetMilitaryPower()
    {
        return militaryPower;
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
    public IEventDefinition PickEvent()
    {
        //pick an event to perform. Should be decided from what would be strategically benefitial and stuffs
        Dictionary<float, IEventDefinition> eventsDesireabilityList = new Dictionary<float, IEventDefinition>();
        foreach(IEventDefinition eventDefinition in availableEvents)
        {
            eventsDesireabilityList.Add(eventDefinition.GetPawnDesireToPerform(this), eventDefinition);
        }
        //if there are no events available
        if(eventsDesireabilityList.Count() == 0)
        {
            return new NullEventDefinition();
        }
        
        return eventsDesireabilityList[eventsDesireabilityList.Keys.Max()];
    }
    public float GetOpinionScoreOfPawn(IPawn otherPawn) //Slightly less messy now, but still very awkward
    {
        List<AspectDefinition> otherPawnAspects = otherPawn.GetAspects();
        BaseOpinionFromCulture baseOpinion = new BaseOpinionFromCulture(otherPawnAspects);
        PersonalOpinionDecorator personalOpinionDecorator = new PersonalOpinionDecorator(baseOpinion, culturalOpinions, otherPawnAspects);
        MilitaryOpinionDecorator militaryOpinionDecorator = new MilitaryOpinionDecorator(personalOpinionDecorator, militaryPower, otherPawn.GetMilitaryPower());
        //we are adding on the relationshipScore to this to get the final resulting opinion. Maybe this should be done in some more elegant way? Or maybe I need to make the terminology more consistent
        if (relationList.Keys.Contains(otherPawn))
        {
            return relationList[otherPawn] + militaryOpinionDecorator.Calculate();
        }
        return 0;
    }

    public bool HasAspect(IAspect aspect)
    {
        if (ownedAspects.Contains(aspect))
        {
            return true;
        }
        return false;
    }

    public void SetAspect(AspectDefinition aspect)
    {
        aspects[aspect.category] = aspect;
    }

    public void ModifyPopularity(float delta)
    {
        popularityScore += delta;
    }
    public IEconomy GetEconomy()
    {
        return personalEconomy;
    }
    public List<AspectDefinition> GetAspects()
    {
        return aspects.Values.ToList();
    }
    public void SetRelationToPawn(IPawn pawn, float relationScore)
    {
        if (relationList.ContainsKey(pawn))
        {
            relationList[pawn] = relationScore;
        }
        else
        {
            relationList.Add(pawn, relationScore);
        }
    }
    public float GetRelationToPawn(IPawn pawn)
    {
        if (relationList.ContainsKey(pawn))
        {
            return relationList[pawn];
        }
        //this pawn does not have a relation to this other pawn!
        return 0;
    }

    public IHierarchyLevel GetHierarchyLevel()
    {
        return hierarchyLevel;
    }
}