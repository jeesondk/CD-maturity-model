using CDMM.Model;
using Microsoft.EntityFrameworkCore;

namespace CDMM.Data;

public class SurveyContext: DbContext
{
    public SurveyContext(DbContextOptions<SurveyContext> options):base(options) { }
    
    public DbSet<SurveyModel> Surveys { get; set; }
    public DbSet<DataPoint> DataPoints { get; set; }
    public DbSet<Respondent> Respondents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SurveyModel>().ToTable("Survey");
        modelBuilder.Entity<DataPoint>().ToTable("DataPoint");
        modelBuilder.Entity<Respondent>().ToTable("Respondent");
    }
}