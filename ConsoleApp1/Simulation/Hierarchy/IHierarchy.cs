public interface IHierarchy
{
    public List<IHierarchyLevel> GetHierarchyLevels(); //the hierarchy is saved as a list, something more robust could be used, but I found too many reasons to do it like this
    public List<IPawn> GetAllPawns();
}