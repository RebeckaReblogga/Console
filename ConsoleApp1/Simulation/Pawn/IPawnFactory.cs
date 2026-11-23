public interface IPawnFactory
{
    public IPawn CreatePawn();
    public List<IPawn> Populate(int amount);
}