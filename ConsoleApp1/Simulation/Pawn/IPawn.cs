using System.Numerics;

public interface IPawn
{
    public string GetName();
    public MilitaryPower GetMilitaryPower();
    public IEconomy GetEconomy();
    public float GetPopularity();
    public void ModifyPopularity(float delta);
    public float GetPower();
    public void SetHierarchyLevel(IHierarchyLevel hierarchyLevel);
    public float GetOpinionScoreOfPawn(IPawn otherPawn);
    public IEventDefinition PickEvent();
    public bool HasAspect(IAspect aspect);
    public void SetAspect(AspectDefinition aspect);
    public List<AspectDefinition> GetAspects();
    public void SetRelationToPawn(IPawn pawn, float relationScore);
    public float GetRelationToPawn(IPawn pawn);
    public IHierarchyLevel GetHierarchyLevel();
    
}