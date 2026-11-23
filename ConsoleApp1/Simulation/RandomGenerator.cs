public class RandomGenerator
{
    Random randomNumberGenerator;
    public RandomGenerator(int seed)
    {
        randomNumberGenerator = new Random(seed);
    }
    public int GetRandomNumber()
    {
        return randomNumberGenerator.Next();
    }
    public int GetRandomNumber(int maxExclusive, int minInclusive = 0)
    {
        return randomNumberGenerator.Next(minInclusive, maxExclusive);
    }
    public float GetRandomNumberSingle()
    {
        return randomNumberGenerator.NextSingle();
    }
    public float GetRandomNumberSingle(float min, float max)
    {
        float baseResult = randomNumberGenerator.NextSingle();
        float finalResult = min + (baseResult*max*2);
        return finalResult;
    }
    public bool RollPercentage(float likelyhood)
    {
        return randomNumberGenerator.NextSingle() <= likelyhood;
    }
}