public class PersonalCulture : ICulture
{
    private ConcreteCulture culturalReference;

    public PersonalCulture(ConcreteCulture culturalReference)
    {
        this.culturalReference = culturalReference;
    }

    public List<AspectCategory> GetAspectCategories()
    {
        //placeholder
        return culturalReference.GetAspectCategories();
    }
}