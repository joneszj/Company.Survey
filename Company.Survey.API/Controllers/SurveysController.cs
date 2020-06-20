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
            //TODO: this is a little crazy and indicative of needing design optimization
            var survey = await _context.Clients.Where(e => e.Email == Email)
                .Include(e => e.ClientSurveys.Where(e => e.ClientSurveyKey == Key))
                    .ThenInclude(e => e.Survey)
                        .ThenInclude(e => e.SurveySteps)
                            .ThenInclude(e => e.Questions)
                                .ThenInclude(e => e.SurveyQuestions)
                // EF 5 preview feature https://docs.microsoft.com/en-us/ef/core/querying/related-data#filtered-include
                .Include(e => e.ClientSurveys.Where(e => e.ClientSurveyKey == Key))
                        .ThenInclude(e => e.ClientQuestionReplies)
                .Include(e => e.ClientSurveys.Where(e => e.ClientSurveyKey == Key))
                    .ThenInclude(e => e.Survey)
                        .ThenInclude(e => e.SurveySteps)
                            .ThenInclude(e => e.StepContent)
                                .ThenInclude(e => e.ContentBlocks)
                .FirstOrDefaultAsync();

            if (survey == null) return NotFound();
            return Ok(new SurveyViewModel(survey.ClientSurveys.Single()));
        }

        [HttpGet("preview/{Id}")]
        public async Task<ActionResult<SurveyViewModel>> GetSurveyByClientSurveyKey(int Id)
        {
            if (!ModelState.IsValid) return NotFound();
            var survey = await _context.Surveys.Where(e => e.Id == Id)
                        .Include(e => e.SurveySteps)
                            .ThenInclude(e => e.Questions)
                                .ThenInclude(e => e.SurveyQuestions)
                        .Include(e => e.SurveySteps)
                            .ThenInclude(e => e.StepContent)
                                .ThenInclude(e => e.ContentBlocks)
                .FirstOrDefaultAsync();

            if (survey == null) return NotFound();
            return Ok(new SurveyViewModel(survey));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateSurvey(PutSurveyViewModel viewModel, [FromQuery] Guid Key)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (!DateTime.TryParse(viewModel.RequestedStartDate, out var start)) ModelState.AddModelError("RequestedStartDate", "Must be DateTime Parsable");
            if (!DateTime.TryParse(viewModel.RequestedEndDate, out var end)) ModelState.AddModelError("RequestedEndDate", "Must be DateTime Parsable");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var survey = await _context.ClientSurveys.Where(e => e.ClientSurveyKey == Key).FirstOrDefaultAsync();
            if (survey == null) return NotFound();
            survey.RequestedEndDate = end;
            survey.RequestedStartDate = start;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> CompleteSurvey([FromQuery] Guid Key)
        {
            var clientSurvey = await _context.ClientSurveys.FirstOrDefaultAsync(e => e.ClientSurveyKey == Key);
            if (clientSurvey == null) return NotFound();
            clientSurvey.IsComplete = true;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
