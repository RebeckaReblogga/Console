public interface ISimulation
{
    public SimulationState GetSimulationState();
    public void Step();
}