public class AspectDefinition : IAspect
{
    public AspectDefinition(AspectCategory category, string name, float desireability)
    {
        this.category = category;
        Name = name;
        this.desireability = desireability;
    }

    public AspectCategory category{get;}
    public string Name{get;}
    public float desireability{get;}
    public float GetDesireAbility()
    {
        throw new NotImplementedException();
    }

    public string GetName()
    {
        throw new NotImplementedException();
    }
}