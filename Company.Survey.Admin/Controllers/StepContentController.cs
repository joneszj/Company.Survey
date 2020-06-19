using System.Linq;
using System.Threading.Tasks;
using Company.Survey.Admin.Models.StepContent;
using Company.Survey.Core.Data;
using Company.Survey.Core.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Company.Survey.Admin.Controllers
{
    public class StepContentController : Controller
    {
        private readonly CoreContext _context;

        public StepContentController(CoreContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] PostStepContent postStepContent)
        {
            var step = await _context.Surveys
                .Include(e => e.SurveySteps)
                .FirstOrDefaultAsync(e => e.Id == postStepContent.SurveyId);
            step.SurveySteps.Where(e => e.Id == postStepContent.StepId).FirstOrDefault().StepContent =
                new StepContent
                {
                    Title = postStepContent.Title
                };
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit", "Questionnaire", new { id = postStepContent.SurveyId });
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] PutStepContent putStepContent)
        {
            var stepContent = await _context.StepContents.FindAsync(putStepContent.StepContentId);
            stepContent.Title = putStepContent.Title;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Remove([FromBody] DeleteStepContent deleteStepContent)
        {
            var stepContent = await _context.StepContents.FindAsync(deleteStepContent.StepContentId);
            _context.StepContents.Remove(stepContent);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
