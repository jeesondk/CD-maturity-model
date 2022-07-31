using CDMM.Model;

namespace CDMM.Entities;

public class SurveyResponseModel
{
    public Guid Id { get; set; }
    public string Respondent { get; set; }
    public DataPoint[] Responses { get; set; }
}