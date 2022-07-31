
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CDMM.Model;

public class SurveyModel
{
    [Key]
    public int Id { get; set; }
    public Guid SurveyId { get; set; }
    public bool IsOpen { get; set; }
}

