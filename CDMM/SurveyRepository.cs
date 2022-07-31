using CDMM.Data;
using CDMM.Entities;
using CDMM.Model;
using Microsoft.EntityFrameworkCore;

namespace CDMM;

public class SurveyRepository
{
    private readonly SurveyContext _context;
    public SurveyRepository(SurveyContext context)
    {
        _context = context;
    }

    public SurveyRequestModel FindSurveyById(Guid surveyId)
    {
        var surveyModel = _context.Surveys.Single(x => x.SurveyId.Equals(surveyId));
        return new SurveyRequestModel
        {
            IsOpen = surveyModel.IsOpen,
            Id = surveyModel.SurveyId,
            MaturityData = _context.DataPoints.Where(x => x.SurveyId.Equals(surveyId)).ToList(),
            Respondents = _context.Respondents.Where(x => x.SurveyId.Equals(surveyId)).ToList()
        };
    }

    public SurveyId CreateNewSurvey()
    {
        var surveyId = new SurveyId();
        _context.Surveys.Add(new SurveyModel {IsOpen = true, SurveyId = surveyId.Id });
        _context.SaveChanges();
        return surveyId;
    }

    public void SaveSurveyResponse(SurveyResponseModel surveyResponseModel)
    {
        _context.Respondents.Add(new Respondent
            {Identification = surveyResponseModel.Respondent, SurveyId = surveyResponseModel.Id});

        var dataPoints = surveyResponseModel.Responses.ToList();
        dataPoints.ForEach( d => d.SurveyId = surveyResponseModel.Id);

        _context.DataPoints.AddRange(dataPoints.ToArray());

        _context.SaveChanges();
    }
}