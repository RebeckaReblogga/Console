public class ConcreteHierarchyLevel : IHierarchyLevel
{
    List<IPawn> members = new List<IPawn>{};

    //could have different constructors if i want i guess
    public ConcreteHierarchyLevel(List<IPawn> pawns)
    {
        Initialize(pawns);
    }
    public ConcreteHierarchyLevel(){}
    public void AddMember(IPawn pawn)
    {
        //should maybe check the pawn isnt already in this level so nothing weird would happen there.
        members.Add(pawn);
        pawn.SetHierarchyLevel(this); //so that the pawn knows what hierarchy level its at
    }
    public List<IPawn> GetMembers()
    {
        return members;
    }
    public void RemoveMember(IPawn pawn)
    {
        if (members.Contains(pawn))
        {
            members.Remove(pawn);
        }
    }
    public void Initialize(List<IPawn> pawns)
    {
        //clear if there are for some reason already pawns assigned
        foreach(IPawn member in members)
        {
            RemoveMember(member);
        }
        //fill with the provided pawns
        foreach(IPawn pawn in pawns)
        {
            AddMember(pawn);
        }
    }
}