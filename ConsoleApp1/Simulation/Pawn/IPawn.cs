using System.Numerics;

public interface IPawn
{
    public IOpinion GetBaseOpinion();
    public IMilitaryPower GetMilitaryPower();
    public float GetPopularity();
    public float GetPower();
}