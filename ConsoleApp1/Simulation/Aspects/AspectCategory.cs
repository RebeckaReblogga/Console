public class AspectCategory
{
    public AspectCategory(string name)
    {
        Name = name;
        _aspects = new List<AspectDefinition>{};
    }
    public List<AspectDefinition> _aspects{get;}
    internal AspectDefinition AddAspect(string name, float desireability)
    {
        var aspect = new AspectDefinition(this, name, desireability);
        _aspects.Add(aspect);
        return aspect;
    }
    public string Name{get;}


}