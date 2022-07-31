using CDMM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CDMM.Controllers;

[ApiController]
[Route("[controller]")]
public class SurveyController : Controller
{
    private readonly SurveyConfig _surveyConfig;
    private readonly SurveyRepository _surveyRepository;
    
    public SurveyController(ISurveyConfig surveyConfig, ISurveyRepository surveyRepository)
    {
        _surveyConfig = (SurveyConfig)surveyConfig;
    }
    
    [HttpGet("config", Name = "GetSetUpSurvey")]
    public ActionResult<SurveyConfig> GetSetUpSurvey()
    {
        return _surveyConfig;
    }
    
    [HttpGet("{id}", Name = "GetSurveyById")]
    public ActionResult<SurveyRequestModel> GetSurveyById(Guid id)
    {
        return _surveyRepository.FindSurveyById(id);
    }

    [HttpPost("create", Name = "CreateSurvey")]
    public ActionResult<SurveyId> CreateSurvey()
    {
        return _surveyRepository.CreateNewSurvey();
    }

    [HttpPost("respond", Name = "SaveSurveyResponse")]
    public ActionResult SaveSurveyResponse(SurveyResponseModel responseModel)
    {
        return Ok();
    }
}