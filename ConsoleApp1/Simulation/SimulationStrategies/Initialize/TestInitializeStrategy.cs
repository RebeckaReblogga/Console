using System.Reflection.Metadata;

public class TestInitializeStrategy : ISimulationInitializeStrategy
{
    public SimulationState Execute() //TODO
    {



        SimulationEconomy simulationEconomy = new SimulationEconomy();
        ConcreteCulture simulationCulture = new ConcreteCulture();
        RandomGenerator randomGenerator = new RandomGenerator(555);

        IHierarchyLevel level1 = new ConcreteHierarchyLevel();
        IHierarchyLevel level2 = new ConcreteHierarchyLevel();
        IHierarchyLevel level3 = new ConcreteHierarchyLevel();

        IHierarchy hierarchy = new ConcreteHierarchy(new List<IHierarchyLevel>{level1, level2, level3});

        List<PawnEventDefinition> availableEvents = new List<PawnEventDefinition>();

        IPawnFactory factory = new NullPawnFactory();

        SimulationState simulation = new ManualInitializeStrategy(hierarchy, simulationEconomy, simulationCulture, randomGenerator, availableEvents, factory).Execute();

        //populating the simulation with stuffs
        //creating all events
        HoldDinnerPartyEventDefinition holdDinnerPartyEventDefinition = new HoldDinnerPartyEventDefinition(simulation, new List<IAspectEventInfluence>{}, 0.5f);
        HoldSpeechEventDefinition holdSpeechEventDefinition = new HoldSpeechEventDefinition(simulation, new List<IAspectEventInfluence>{}, 1f);
        AssassinationEventDefintion assassinationEventDefintion = new AssassinationEventDefintion(simulation, new List<IAspectEventInfluence>{}, -0.5f);

        availableEvents = new List<PawnEventDefinition>{holdDinnerPartyEventDefinition, holdSpeechEventDefinition, assassinationEventDefintion};
        simulation = new ManualInitializeStrategy(hierarchy, simulationEconomy, simulationCulture, randomGenerator, availableEvents, factory).Execute();
        //assigning factory

        factory = new MinimalRandomPawnFactory(simulation);
        //adding the pawns to the hierarchy
        foreach(IHierarchyLevel hierarchyLevel in hierarchy.GetHierarchyLevels())
        {
            hierarchyLevel.Initialize(factory.Populate(6));
        }
        //setting up the relationships between every pawn
        //this could almost be its own strategy or something like that
        //right now i just set all the relations to 0 at the start
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