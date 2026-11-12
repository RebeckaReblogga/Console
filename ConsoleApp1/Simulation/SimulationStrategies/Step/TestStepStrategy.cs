public class TestStepStrategy : ISimulationStepStrategy
{
    public SimulationState Execute(SimulationState state) //TODO
    {
        foreach(IPawn pawn in state.hierarchy.GetAllPawns())
        {
            foreach(IPawn otherPawn in state.hierarchy.GetAllPawns())
            {
                if (otherPawn != pawn)
                    Console.WriteLine(pawn.GetName() + " has this opinion of " + otherPawn.GetName() + ": " + pawn.GetOpinionOfPawn(otherPawn).Calculate().ToString());
            }
        }
        return state;
    }
}