public class SimulationState
{
    List<IHierarchyLevel> hierarchyLevels{get; set;}
    IEconomy economy{get; set;}
    ICulture culture{get; set;}
    public SimulationState(List<IHierarchyLevel> hierarchyLevels, IEconomy economy, ICulture culture)    //This constructor is where we will actually set up the simulation
    {
        this.hierarchyLevels = hierarchyLevels;
        this.economy = economy;
        this.culture = culture;
    }
}