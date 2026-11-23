public class RelationScoreChangeAction : IAction
{
    IPawn pawn;
    IPawn otherPawn;
    float change;

    public RelationScoreChangeAction(IPawn pawn, IPawn otherPawn, float change)
    {
        this.pawn = pawn;
        this.otherPawn = otherPawn;
        this.change = change;
    }

    public void Execute(SimulationState state)
    {
        pawn.SetRelationToPawn(otherPawn, pawn.GetRelationToPawn(otherPawn) + change);
    }
}