namespace CDMM.Entities;

public interface ISurveyConfig
{
    string[] Categories { get; }
    MaturityLevel[] MaturityLevels { get; }
}