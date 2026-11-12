public class TestInitializeStrategy : ISimulationInitializeStrategy
{
    public SimulationState Execute() //TODO
    {
        MinimalRandomPawnFactory factory = new MinimalRandomPawnFactory();

        IHierarchyLevel level1 = new ConcreteHierarchyLevel(factory.Populate(5));
        IHierarchyLevel level2 = new ConcreteHierarchyLevel(factory.Populate(5));
        IHierarchyLevel level3 = new ConcreteHierarchyLevel(factory.Populate(5));

        
        IHierarchy hierarchy = new ConcreteHierarchy(new List<IHierarchyLevel>{level1, level2, level3});
        return new ManualInitializeStrategy(hierarchy, new SimulationEconomy(), new ConcreteCulture()).Execute();
    }
}