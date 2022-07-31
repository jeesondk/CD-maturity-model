namespace CDMM.Entities;

public class MaturityLevel
{
    public int Score { get; }
    public string Definition { get; }
    
    public MaturityLevel(int score, string definition)
    {
        Score = score;
        Definition = definition;
    }
}