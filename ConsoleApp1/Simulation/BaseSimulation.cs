public class BaseSimulation : ISimulation
{
    SimulationState currentState;
    public SimulationState GetSimulationState()
    {
        return currentState;
    }
    public void Step()
    {
        //changes the current state according to what happens in this step of the simulation
    }
}