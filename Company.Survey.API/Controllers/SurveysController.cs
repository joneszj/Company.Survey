using Company.Survey.API.ViewModels;
using Company.Survey.Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Survey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveysController : ControllerBase
    {
        private readonly CoreContext _context;

        public SurveysController(CoreContext context) => _context = context;

        [HttpGet("{Email}")]
        public async Task<ActionResult<SurveyViewModel>> GetSurveyByClientSurveyKey(string Email, [FromQuery] Guid Key)
        {
            //TODO: this is a little crazy and indicative of design optimization
            var survey = await _context.Clients.Where(e => e.Email == Email)
                .Include(e => e.ClientSurveys.Where(e => e.ClientSurveyKey == Key))
                    .ThenInclude(e => e.Survey)
                        .ThenInclude(e => e.SurveySteps)
                            .ThenInclude(e => e.Questions)
                // EF 5 preview feature https://docs.microsoft.com/en-us/ef/core/querying/related-data#filtered-include
                .Include(e => e.ClientSurveys.Where(e => e.ClientSurveyKey == Key))
                    .ThenInclude(e => e.Survey)
                        .ThenInclude(e => e.SurveySteps)
                            .ThenInclude(e => e.QuestionGroups)
                                .ThenInclude(e => e.SurveyGroupQuestions)
                .Include(e => e.ClientSurveys.Where(e => e.ClientSurveyKey == Key))
                        .ThenInclude(e => e.ClientQuestionReplies)
                .FirstOrDefaultAsync();

            if (survey == null) return NotFound();
            return Ok(new SurveyViewModel(survey.ClientSurveys.Single()));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateSurvey(PutSurveyViewModel viewModel, [FromQuery] Guid Key)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var survey = await _context.ClientSurveys.Where(e => e.ClientSurveyKey == Key).FirstOrDefaultAsync();
            if (survey == null) return NotFound();
            survey.RequestedEndDate = viewModel.RequestedEndDate;
            survey.RequestedStartDate = viewModel.RequestedStartDate;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
