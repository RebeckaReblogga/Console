public class EconomyChangeAction : IAction
{
    IEconomy economy;
    private float change;

    public EconomyChangeAction(IEconomy economy, float change)
    {
        this.economy = economy;
        this.change = change;
    }

    public void Execute(SimulationState state)
    {
        economy.ChangeEconomyScore(change);
    }
}