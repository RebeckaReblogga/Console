public class BaseOpinionFromCulture : IOpinion {
    List<AspectDefinition> aspects;
    public BaseOpinionFromCulture(List<AspectDefinition> aspects)
    {
        this.aspects = aspects;
    }
    public float Calculate()
    {
        float result = 0;
        foreach(AspectDefinition aspect in aspects)
        {
            result += aspect.desireability;
        }
        return result;
    }
}