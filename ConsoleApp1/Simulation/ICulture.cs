public interface ICulture
{
    public List<IAspect> GetAspects();
    public float GetAspectDesireability(IAspect aspect);
}