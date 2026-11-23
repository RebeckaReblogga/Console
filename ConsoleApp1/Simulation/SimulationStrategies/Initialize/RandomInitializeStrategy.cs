public class RandomInitializeStrategy : ISimulationInitializeStrategy
{
    public SimulationState Execute() //TODO
    {
        SimulationEconomy simulationEconomy = new SimulationEconomy();
        ConcreteCulture simulationCulture = new ConcreteCulture();
        RandomGenerator randomGenerator = new RandomGenerator(DateTime.Now.Millisecond);

        IHierarchyLevel level1 = new ConcreteHierarchyLevel();
        IHierarchyLevel level2 = new ConcreteHierarchyLevel();
        IHierarchyLevel level3 = new ConcreteHierarchyLevel();

        IHierarchy hierarchy = new ConcreteHierarchy(new List<IHierarchyLevel>{level1, level2, level3});

        List<PawnEventDefinition> availableEvents = new List<PawnEventDefinition>();

        IPawnFactory factory = new NullPawnFactory();

        SimulationState simulation = new ManualInitializeStrategy(hierarchy, simulationEconomy, simulationCulture, randomGenerator, availableEvents, factory).Execute();

        //populating the simulation with stuffs
        //creating all events
        
        BaseEvents baseEvents = new BaseEvents(simulation);

        availableEvents = baseEvents.GetEvents();
        simulation = new ManualInitializeStrategy(hierarchy, simulationEconomy, simulationCulture, randomGenerator, availableEvents, factory).Execute();
        //assigning factory

        factory = new RandomPawnFactory(simulation);
        //adding the pawns to the hierarchy
        foreach(IHierarchyLevel hierarchyLevel in hierarchy.GetHierarchyLevels())
        {
            hierarchyLevel.Initialize(factory.Populate(6));
        }
        //setting up the relationships between every pawn
        //this could almost be its own strategy or something like that
        foreach(IPawn pawn in hierarchy.GetAllPawns())
        {
            foreach(IPawn otherPawn in hierarchy.GetAllPawns())
            {
                if(otherPawn == pawn)
                    continue;
                else
                    pawn.SetRelationToPawn(otherPawn, randomGenerator.GetRandomNumberSingle(-2, 2));
            }
        } 
        

        simulation = new ManualInitializeStrategy(hierarchy, simulationEconomy, simulationCulture, randomGenerator, availableEvents, factory).Execute();

        return simulation;
    }
}