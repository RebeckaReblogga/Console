public class NullPawn : IPawn
{
    public List<AspectDefinition> GetAspects()
    {
        return new List<AspectDefinition>{};
    }

    public IEconomy GetEconomy()
    {
        throw new NotImplementedException();
    }

    public IHierarchyLevel GetHierarchyLevel()
    {
        throw new NotImplementedException();
    }

    public MilitaryPower GetMilitaryPower()
    {
        return new MilitaryPower(new List<MilitaryAsset>{});
    }

    public string GetName()
    {
        throw new NotImplementedException();
    }

    public float GetOpinionScoreOfPawn(IPawn otherPawn)
    {
        throw new NotImplementedException();
    }

    public float GetPopularity()
    {
        throw new NotImplementedException();
    }

    public float GetPower()
    {
        throw new NotImplementedException();
    }

    public float GetRelationToPawn(IPawn pawn)
    {
        throw new NotImplementedException();
    }

    public bool HasAspect(IAspect aspect)
    {
        throw new NotImplementedException();
    }

    public void ModifyPopularity(float delta)
    {
        throw new NotImplementedException();
    }

    public IEventDefinition PickEvent()
    {
        throw new NotImplementedException();
    }

    public void SetAspect(AspectDefinition aspect)
    {
        throw new NotImplementedException();
    }

    public void SetHierarchyLevel(IHierarchyLevel hierarchyLevel)
    {
        throw new NotImplementedException();
    }

    public void SetRelationToPawn(IPawn pawn, float relationScore)
    {
        throw new NotImplementedException();
    }
}