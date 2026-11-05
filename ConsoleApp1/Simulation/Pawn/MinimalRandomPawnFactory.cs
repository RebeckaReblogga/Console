using System.Security.Cryptography.X509Certificates;

public class MinimalRandomPawnFactory : IPawnFactory
{
    public IPawn CreatePawn()
    {
        return new ConcretePawn("what would you do if when you okay so he said yes would go?");
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