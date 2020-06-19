using System.Linq;
using System.Threading.Tasks;
using Company.Survey.Admin.Models;
using Company.Survey.Core.Data;
using Company.Survey.Core.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Company.Survey.Admin.Controllers
{
    [Authorize]
    public class StepController : Controller
    {
        private readonly CoreContext _context;

        public StepController(CoreContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] PostSurveyStep postStepViewModel)
        {
            var survey = await _context.Surveys
                .Include(e => e.SurveySteps.OrderBy(e => e.Order))
                .FirstOrDefaultAsync(e => e.Id == postStepViewModel.SurveyId);
            var steps = survey.SurveySteps.ToArray();
            if (postStepViewModel.Order != -1)
            {
                for (int i = 0; i < steps.Length; i++)
                {
                    steps[i].Order = i;
                    if (i == postStepViewModel.Order) steps[i].Order = i + 1;
                }
            }
            var newSurvey = new SurveyStep
            {
                Order = postStepViewModel.Order == -1 ? survey.SurveySteps.Count + 1 : postStepViewModel.Order,
                Title = postStepViewModel.Title
            };
            survey.SurveySteps.Add(newSurvey);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit", "Questionnaire", new { id = postStepViewModel.SurveyId });
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] PutSurveyStep surveyStep)
        {
            var step = await _context.SurveySteps.FindAsync(surveyStep.Id);
            step.Title = surveyStep.Title;
            if (surveyStep.Order.HasValue) step.Order = surveyStep.Order.Value;

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Remove([FromBody] RemoveSurveyStep surveyStep)
        {
            var step = await _context.SurveySteps.FindAsync(surveyStep.StepId);
            _context.SurveySteps.Remove(step);
            await _context.SaveChangesAsync();
            var survey = await _context.Surveys
                .Include(e => e.SurveySteps.OrderBy(e=>e.Order))
                .FirstOrDefaultAsync(e => e.Id == step.SurveyId);
            var order = 0;
            // strangely, the .Include(e => e.SurveySteps.OrderBy(e=>e.Order)) seems to ignore query filters :/
            survey.SurveySteps.Where(e=>e.IsActive).ToList().ForEach((step) => { step.Order = order++; });
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
