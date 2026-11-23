using System.Security.Cryptography;

public class SimulationEconomy : IEconomy
{
    private float economyScore;
    public float GetEconomyScore()
    {
        return economyScore;
    }
    public void StepEconomy()
    {
        economyScore += ChangeFormula();
        Math.Clamp(economyScore, 0, 1);
    }
    public float ChangeFormula()
    {
        var random = new Random();
        float randomNmbr = (random.Next(0,100)-50)/100;
        return (float)(1/(0.7*Math.Sqrt(2*Math.PI)))*(float)(Math.Pow(Math.E, Math.Pow(randomNmbr,2)/2*Math.Pow(0.7,2)))-(float)(1/(0.7*Math.Sqrt(2*Math.PI)));
    }

    public void ChangeEconomyScore(float change)
    {
        economyScore += change;
        Math.Clamp(economyScore, 0, 1);
    }
}