public interface IHierarchyLevel
{
    public List<IPawn> GetMembers();
    public void AddMember(IPawn pawn);
    public void RemoveMember(IPawn pawn);
}