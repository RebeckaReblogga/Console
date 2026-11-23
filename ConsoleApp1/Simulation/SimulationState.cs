public class SimulationState
{
    public SimulationState(IHierarchy hierarchy, IEconomy economy, ICulture culture, RandomGenerator randomGenerator, List<PawnEventDefinition> availableEvents, IPawnFactory pawnFactory)
    {
        this.hierarchy = hierarchy;
        this.economy = economy;
        this.culture = culture;
        this.randomGenerator = randomGenerator;
        this.availableEvents = availableEvents;
        this.pawnFactory = pawnFactory;
    }

    public IHierarchy hierarchy{get; private set;}
    public IEconomy economy{get; private set;}
    public ICulture culture{get; private set;}
    public RandomGenerator randomGenerator{get;}
    public List<PawnEventDefinition> availableEvents{get;}
    public List<string> stepDescriptions;
    public IPawnFactory pawnFactory;
    
}