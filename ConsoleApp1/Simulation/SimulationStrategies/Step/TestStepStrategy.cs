public class TestStepStrategy : ISimulationStepStrategy
{
    public SimulationState Execute(SimulationState state) //TODO
    {
        foreach(IHierarchyLevel hierarchyLevel in state.hierarchy.GetHierarchyLevels())
        {
            foreach(IPawn pawn in hierarchyLevel.GetMembers())
            {
                Console.WriteLine(pawn.GetName());
            }
        }
        return state;
    }
}