public class PersonalOpinionDecorator : OpinionDecorator
{
    PersonalCulture culturalOpinions;
    List<AspectDefinition> aspects;  //think im going to improve the aspects system so that it's a bit better

    public PersonalOpinionDecorator(IOpinion decoratedOpinion, PersonalCulture culturalOpinions, List<AspectDefinition> aspects) : base(decoratedOpinion)
    {
        this.culturalOpinions = culturalOpinions;
        this.aspects = aspects;
    }

    public override float Calculate()
    {
        //calculate what this pawn thinks of other pawn from 
        float result = 0;
        foreach(AspectDefinition aspect in aspects)
        {
            if (culturalOpinions.opinionsOnAspects.ContainsKey(aspect))
            {
                result += culturalOpinions.opinionsOnAspects[aspect];
            }
        }
        return result;
    }
}