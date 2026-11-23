public class PersonalEconomy : IEconomy
{
    IEconomy systemEconomy;
    float economyScore;

    public PersonalEconomy(IEconomy systemEconomy)
    {
        this.systemEconomy = systemEconomy;
    }
    public float GetEconomyScore() // TODO
    {
        return economyScore;
    }
    public void StepEconomy()
    {
        //ofc needs to be changed!!!
        economyScore = systemEconomy.GetEconomyScore();
    }
    public void ChangeEconomyScore(float change)
    {
        economyScore += change;
        Math.Clamp(economyScore, 0, 1);
    }
}