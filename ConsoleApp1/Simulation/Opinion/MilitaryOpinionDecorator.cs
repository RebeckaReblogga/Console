public class MilitaryOpinionDecorator : OpinionDecorator
{
    MilitaryPower pawnMilitaryPower;
    MilitaryPower otherPawnMilitaryPower;

    public MilitaryOpinionDecorator(IOpinion decoratedOpinion, MilitaryPower pawnMilitaryPower, MilitaryPower otherPawnMilitaryPower) : base(decoratedOpinion)
    {
        this.pawnMilitaryPower = pawnMilitaryPower;
        this.otherPawnMilitaryPower = otherPawnMilitaryPower;
    }
    public override float Calculate()
    {
        float result = 0;
        
        return decoratedOpinion.Calculate();
    }
}