using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CDMM.Model;

public class DataPoint
{
    [Key]
    [JsonIgnore]
    public int Id { get; set; }
    [JsonIgnore]
    public Guid SurveyId { get; set; }
    public string app { get; set; }
    public string axis { get; set; }
    public int value { get; set; }
}