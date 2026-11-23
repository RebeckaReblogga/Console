public class ManualInitializeStrategy : ISimulationInitializeStrategy
{
    IHierarchy hierarchy;
    IEconomy economy;
    ICulture culture;
    RandomGenerator randomGenerator;
    List<PawnEventDefinition> availableEvents;
    IPawnFactory pawnFactory;

    public ManualInitializeStrategy(IHierarchy hierarchy, IEconomy economy, ICulture culture, RandomGenerator randomGenerator, List<PawnEventDefinition> availableEvents, IPawnFactory pawnFactory)
    {
        this.hierarchy = hierarchy;
        this.economy = economy;
        this.culture = culture;
        this.randomGenerator = randomGenerator;
        this.availableEvents = availableEvents;
        this.pawnFactory = pawnFactory;
    }

    public SimulationState Execute()
    {
        return new SimulationState(hierarchy, economy, culture, randomGenerator, availableEvents, pawnFactory);
    }
}