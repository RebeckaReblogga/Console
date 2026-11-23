public class AspectPreference : IAspectEventInfluence
{
    protected IAspect aspect;
    protected float influence;

    public AspectPreference(IAspect aspect, float influence)
    {
        this.aspect = aspect;
        this.influence = influence;
    }

    public IAspect GetAspect()
    {
        return aspect;
    }

    public float GetInfluence()
    {
        return influence;
    }
}