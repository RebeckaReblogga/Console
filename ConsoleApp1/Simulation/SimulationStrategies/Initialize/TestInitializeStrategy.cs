public class TestInitializeStrategy : ISimulationInitializeStrategy
{
    public SimulationState Execute() //TODO
    {
        //create a hierarchy list
        List<IHierarchyLevel> hierarchyLevels = new List<IHierarchyLevel>{};
        //create economy
        IEconomy economy = new SimulationEconomy();
        //create culture
        ICulture culture = new ConcreteCulture();
        return new SimulationState(hierarchyLevels, economy, culture);
    }
}