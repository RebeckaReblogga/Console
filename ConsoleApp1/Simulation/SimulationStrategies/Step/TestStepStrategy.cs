public class TestStepStrategy : ISimulationStepStrategy
{
    public SimulationState Execute(SimulationState state) //TODO
    {
        List<string> eventDescriptions = new List<string>{};
        foreach(IPawn pawn in state.hierarchy.GetAllPawns())
        {
            //picking the event
            // IEventDefinition pickedEventType = pawn.PickEvent();
            IEventDefinition pickedEventType = state.availableEvents[state.randomGenerator.GetRandomNumber(state.availableEvents.Count)];
            IEvent createdEvent = pickedEventType.CreateEvent(state.randomGenerator, pawn);
            List<IAction> effects = createdEvent.Perform(state.randomGenerator);
            eventDescriptions.Add(createdEvent.GetEventDescription());
            //actually executing the effects of the event
            foreach(IAction effect in effects)
            {
                effect.Execute(state);
            }
        }
        state.stepDescriptions = eventDescriptions;
        return state;
    }
}