public class AspectDefinition : IAspect
{
    public AspectDefinition(AspectCategory category, string name, float desireability)
    {
        this.category = category;
        this.name = name;
        this.desireability = desireability;
    }

    public AspectCategory category{get;}
    public string name{get;}
    public float desireability{get;}
    public float GetDesireAbility()
    {
        return desireability;
    }

    public string GetName()
    {
        return name;
    }
}