using CDMM.Model;

namespace CDMM.Entities;

public class SurveyRequestModel
{
    public Guid Id { get; set; }
    public bool IsOpen { get; set; }
    public List<Respondent> Respondents { get; set; }
    public List<DataPoint> MaturityData { get; set; }
}