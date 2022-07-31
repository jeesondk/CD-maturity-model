namespace CDMM.Entities;

public class SurveyConfig : ISurveyConfig
{
    public string[] Categories { get; } 
    public MaturityLevel[] MaturityLevels { get; }

    public SurveyConfig()
    {
        Categories = new []
        {
            "Build Management and Continuous Integration",
            "Environments and Deployment",
            "Release Management and Compliance",
            "Testing",
            "Data Management",
            "Configuration Management"
        };
            
        MaturityLevels = new MaturityLevel[]
        {
            new(score: -2, definition: "Unranked"),
            new(score: -1, definition: "Regressive"),
            new(score: 0, definition: "Repeatable"),
            new(score: 1, definition: "Consistent"),
            new(score: 2, definition: "Quantitatively Managed"),
            new(score: 3, definition: "Optimizing")
        };
    }
}