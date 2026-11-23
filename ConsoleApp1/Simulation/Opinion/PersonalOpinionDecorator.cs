public class PersonalOpinionDecorator : OpinionDecorator
{
    ICulture culturalOpinions;
    List<AspectDefinition> aspects;  //think im going to improve the aspects system so that it's a bit better

    public PersonalOpinionDecorator(IOpinion decoratedOpinion, ICulture culturalOpinions, List<AspectDefinition> aspects) : base(decoratedOpinion)
    {
        this.culturalOpinions = culturalOpinions;
        this.aspects = aspects;
    }

    public override float Calculate()
    {
        //calculate what this pawn thinks of other pawn from 
        return 0;
    }
}