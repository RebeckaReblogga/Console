public class PersonalCulture
{
    private ICulture culturalReference;
    public Dictionary<AspectDefinition, float> opinionsOnAspects = new Dictionary<AspectDefinition, float>();

    public PersonalCulture(ICulture culturalReference, RandomGenerator randomGenerator)
    {
        this.culturalReference = culturalReference;
        foreach(AspectCategory category in culturalReference.GetAspectCategories())
        {
            foreach(AspectDefinition aspectDefinition in category._aspects)
            {
                opinionsOnAspects.Add(aspectDefinition, randomGenerator.GetRandomNumberSingle(-1, 1));
            }
        }
    }
}