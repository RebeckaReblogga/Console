public abstract class OpinionDecorater : IOpinion
{
    private IOpinion decoratedOpinion;
    public abstract float Calculate();
}