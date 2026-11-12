public class ConcreteHierarchy : IHierarchy
{
    protected List<IHierarchyLevel> hierarchyLevels;
    public ConcreteHierarchy(List<IHierarchyLevel> hierarchyLevels)
    {
        this.hierarchyLevels = hierarchyLevels;
    }

    public List<IPawn> GetAllPawns()
    {
        List<IPawn> allPawns = new List<IPawn>{};
        foreach(IHierarchyLevel hierarchyLevel in hierarchyLevels)
        {
            foreach(IPawn pawn in hierarchyLevel.GetMembers())
            {
                allPawns.Add(pawn);
            }
        }
        return allPawns;
    }

    public List<IHierarchyLevel> GetHierarchyLevels()
    {
       return hierarchyLevels;
    }
}