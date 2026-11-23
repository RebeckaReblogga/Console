public class AddPawnAction : IAction
{
    IPawnFactory factory;
    IHierarchyLevel hierarchyLevel;

    public AddPawnAction(IPawnFactory factory, IHierarchyLevel hierarchyLevel)
    {
        this.factory = factory;
        this.hierarchyLevel = hierarchyLevel;
    }

    public void Execute(SimulationState state)
    {
        IPawn createdPawn = factory.CreatePawn();
        hierarchyLevel.AddMember(createdPawn);
    }
}