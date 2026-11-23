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

        personality.AddAspect("extroverted", 4);
        personality.AddAspect("neurotic", 1);
        personality.AddAspect("cold", 2);
        personality.AddAspect("charismatic", 3);

        gender.AddAspect("male", 0.2f);
        gender.AddAspect("female", 4);
    }
    public AspectDefinition TryGetAspect(AspectCategory category, string name)
    {
        foreach(AspectDefinition aspect in category._aspects)
        {
            if(aspect.name == name)
            {
                return aspect;
            }
        }
        //the aspect was not found
        //fix this some time
        return  new AspectDefinition(null, null, 0);
    }
}