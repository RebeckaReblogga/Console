public class SimulationState
{
    public IHierarchy hierarchy{get; private set;}
    public IEconomy economy{get; private set;}
    public ICulture culture{get; private set;}
    public SimulationState(IHierarchy hierarchy, IEconomy economy, ICulture culture)    //This constructor is where we will actually set up the simulation
    {
        this.hierarchy = hierarchy;
        this.economy = economy;
        this.culture = culture;
    }
}