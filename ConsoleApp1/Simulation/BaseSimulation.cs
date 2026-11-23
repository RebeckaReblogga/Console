public class BaseSimulation : ISimulation
{
    private SimulationState currentState;
    private ISimulationInitializeStrategy initializeStrategy;
    private ISimulationStepStrategy stepStrategy;

    public BaseSimulation(ISimulationInitializeStrategy initializeStrategy, ISimulationStepStrategy stepStrategy)
    {
        this.initializeStrategy = initializeStrategy;
        this.stepStrategy = stepStrategy;
        Initialize();
    }

    public SimulationState GetSimulationState()
    {
        return currentState;
    }
    public void Initialize()
    {
        currentState = initializeStrategy.Execute();
    }
    public void Step()
    {
        currentState = stepStrategy.Execute(currentState);
    }
}