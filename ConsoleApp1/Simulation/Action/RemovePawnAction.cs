public class RemovePawnAction : IAction
{
    IPawn pawnToRemove;

    public RemovePawnAction(IPawn pawnToRemove)
    {
        this.pawnToRemove = pawnToRemove;
    }

    public void Execute(SimulationState state) //alot more has to happen here so that references to this pawn are removed
    {
        pawnToRemove.GetHierarchyLevel().RemoveMember(pawnToRemove);
    }
}