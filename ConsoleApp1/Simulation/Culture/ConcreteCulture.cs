public class ConcreteCulture : ICulture
{
    private List<IAspect> aspects;

    public List<IAspect> GetAspects()
    {
        return aspects;
    }
}