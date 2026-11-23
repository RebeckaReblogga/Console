ISimulation simulation = new BaseSimulation(new TestInitializeStrategy(), new TestStepStrategy());
var state = simulation.GetSimulationState();
simulation.Step();
bool running = true;
while (running)
{
    var key = Console.ReadKey();
    if (key.Key == ConsoleKey.S)
    {
        running = false;
    }
    else if (key.Key == ConsoleKey.A)
    {
        simulation.Step();
        Console.WriteLine("Step Taken");
        foreach(string description in simulation.GetSimulationState().stepDescriptions)
        {
            Console.WriteLine(description);
        }
    }
}