namespace CDMM.Entities;

public class SurveyId
{
    public Guid Id { get; }
    public SurveyId()
    {
        Id = Guid.NewGuid();
    }
}