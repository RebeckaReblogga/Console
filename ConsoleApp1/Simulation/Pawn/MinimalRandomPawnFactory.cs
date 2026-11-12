using System.Security.Cryptography.X509Certificates;

public class MinimalRandomPawnFactory : IPawnFactory
{
    public IPawn CreatePawn()
    {
        return new ConcretePawn("name");
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