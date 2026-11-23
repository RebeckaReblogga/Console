public class MilitaryPower
{
    public List<MilitaryAsset> militaryAssets;

    public MilitaryPower(List<MilitaryAsset> militaryAssets)
    {
        this.militaryAssets = militaryAssets;
    }
    public float CalculateScore()
    {
        float score = 0;
        foreach(MilitaryAsset asset in militaryAssets)
        {
            score += asset.value;
        }
        return score;
    }
}