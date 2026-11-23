public class NullPawnFactory : IPawnFactory
{
    public IPawn CreatePawn()
    {
        return new NullPawn();
    }

    public List<IPawn> Populate(int amount)
    {
        return new List<IPawn>{}; 
    }
}