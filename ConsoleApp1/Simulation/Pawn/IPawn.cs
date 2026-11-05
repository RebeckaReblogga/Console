using System.Numerics;

public interface IPawn
{
    public string GetName();
    public IOpinion GetBaseOpinion();
    public IMilitaryPower GetMilitaryPower();
    public float GetPopularity();
    public float GetPower();
    public void SetHierarchyLevel(IHierarchyLevel hierarchyLevel);
}