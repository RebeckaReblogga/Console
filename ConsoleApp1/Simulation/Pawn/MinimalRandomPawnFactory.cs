using System.Globalization;

public class MinimalRandomPawnFactory : IPawnFactory
{
    private SimulationState state;
    private ICulture culturalReference;
    private IEconomy systemEconomy;
    private List<IHierarchyLevel> hierarchyLevels;
    private List<PawnEventDefinition> availableEvents = new List<PawnEventDefinition>{};
    protected RandomGenerator randomGenerator;

    public MinimalRandomPawnFactory(SimulationState state)
    {
        this.state = state;
        culturalReference = this.state.culture;
        systemEconomy = this.state.economy;
        hierarchyLevels = this.state.hierarchy.GetHierarchyLevels();
        availableEvents = this.state.availableEvents;
        randomGenerator = this.state.randomGenerator;
    }

    public IPawn CreatePawn()
    {
        IPawn pawn = new ConcretePawn("name", new MilitaryPower(new List<MilitaryAsset>{}), 0.5f, availableEvents, culturalReference, culturalReference, hierarchyLevels[0], new PersonalEconomy(systemEconomy), randomGenerator);
        foreach(AspectCategory aspectCategory in culturalReference.GetAspectCategories())
        {
            pawn.SetAspect(aspectCategory._aspects[randomGenerator.GetRandomNumber(aspectCategory._aspects.Count)]);
        }
        return pawn;
    }
    public List<IPawn> Populate(int count)
    {
        List<IPawn> pawns = new List<IPawn>{};
        for (int i = 0; i < count; i++)
        {
            pawns.Add(CreatePawn());
        }
        return pawns;
    }
}