public class ConcreteCulture : ICulture
{
    public AspectCategory AddCategory(string name)
    {
        var category = new AspectCategory(name);
        return category;   
    }

    public List<AspectCategory> GetAspectCategories()
    {
        return new List<AspectCategory>{ideology, personality, gender};
    }

    public AspectCategory ideology{get;}
    public AspectCategory personality{get;}
    public AspectCategory gender{get;}
    public ConcreteCulture()
    {
        ideology = AddCategory("ideology");
        personality = AddCategory("personality");
        gender = AddCategory("gender");


        ideology.AddAspect("authoritarian", 2);
        ideology.AddAspect("libertarian", 1);
        ideology.AddAspect("pacifist", 1);
        ideology.AddAspect("warmonger", 3);

        personality.AddAspect("personable", 4);
        personality.AddAspect("neurotic", 1);
        personality.AddAspect("cold", 2);
        personality.AddAspect("charismatic", 3);

        gender.AddAspect("male", 0.2f);
        gender.AddAspect("female", 4);
    }
    
}