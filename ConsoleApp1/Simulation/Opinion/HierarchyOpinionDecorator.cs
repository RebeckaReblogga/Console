public class hierarchyOpinionDecorator : OpinionDecorator
{
    public hierarchyOpinionDecorator(IOpinion decoratedOpinion) : base(decoratedOpinion)
    {
        
    }
    public override float Calculate()
    {
        throw new NotImplementedException();
    }
}