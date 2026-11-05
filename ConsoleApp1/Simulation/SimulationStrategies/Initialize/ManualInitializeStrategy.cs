public class ManualInitializeStrategy : ISimulationInitializeStrategy
{
    IHierarchy hierarchy;
    IEconomy economy;
    ICulture culture;

    public ManualInitializeStrategy(IHierarchy hierarchy, IEconomy economy, ICulture culture)
    {
        this.hierarchy = hierarchy;
        this.economy = economy;
        this.culture = culture;
    }

    public SimulationState Execute()
    {
        return new SimulationState(hierarchy, economy, culture);
    }
}