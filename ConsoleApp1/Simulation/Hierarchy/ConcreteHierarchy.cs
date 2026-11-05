public class ConcreteHierarchy : IHierarchy
{
    List<IHierarchyLevel> hierarchyLevels;

    public ConcreteHierarchy(List<IHierarchyLevel> hierarchyLevels)
    {
        this.hierarchyLevels = hierarchyLevels;
    }
    public List<IHierarchyLevel> GetHierarchyLevels()
    {
        return hierarchyLevels;
    }
}