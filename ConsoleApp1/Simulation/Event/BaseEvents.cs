public class BaseEvents
{   
    SimulationState simulation;
    public HoldDinnerPartyEventDefinition holdDinnerPartyEventDefinition{get;}
    public HoldSpeechEventDefinition holdSpeechEventDefinition{get;}
    public AssassinationEventDefintion assassinationEventDefintion{get;}

    public BaseEvents(SimulationState simulation)
    {
        this.simulation = simulation;
        ConcreteCulture culture = (ConcreteCulture)simulation.culture;


        holdDinnerPartyEventDefinition = new HoldDinnerPartyEventDefinition(simulation, 0.5f);
        holdDinnerPartyEventDefinition.AddInfluence(new AspectPreference(culture.TryGetAspect(culture.personality, "extroverted"), 1));

        holdSpeechEventDefinition = new HoldSpeechEventDefinition(simulation, 1f);
        holdSpeechEventDefinition.AddInfluence(new AspectPreference(culture.TryGetAspect(culture.ideology, "libertarian"), 2));
        holdSpeechEventDefinition.AddInfluence(new AspectPreference(culture.TryGetAspect(culture.ideology, "pacifist"), 1));


        assassinationEventDefintion = new AssassinationEventDefintion(simulation, -0.5f);
        assassinationEventDefintion.AddInfluence(new AspectPreference(culture.TryGetAspect(culture.personality, "neurotic"), 3));
        assassinationEventDefintion.AddInfluence(new AspectPreference(culture.TryGetAspect(culture.personality, "cold"), 2));
        assassinationEventDefintion.AddInfluence(new AspectPreference(culture.TryGetAspect(culture.ideology, "warmonger"), 1));
    }
    public List<PawnEventDefinition> GetEvents()
    {
        return new List<PawnEventDefinition>{holdDinnerPartyEventDefinition, holdSpeechEventDefinition, assassinationEventDefintion};
    }
}