public class BaseOpinion : IOpinion {
    private float BaseOpinionScore{get;}
    public float Calculate()
    {
        return BaseOpinionScore;
    }
}