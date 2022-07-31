using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CDMM.Model;

public class Respondent
{
    [Key]
    [JsonIgnore]
    public int RespondentId { get; set; }
    public string Identification { get; set; }
    [JsonIgnore]
    public Guid SurveyId { get; set; }
}