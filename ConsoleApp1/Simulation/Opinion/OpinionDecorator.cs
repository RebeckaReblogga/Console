public abstract class OpinionDecorator : IOpinion
{
    protected IOpinion decoratedOpinion;
    public OpinionDecorator(IOpinion decoratedOpinion)
    {
        this.decoratedOpinion = decoratedOpinion;
    }

    public abstract float Calculate();
}