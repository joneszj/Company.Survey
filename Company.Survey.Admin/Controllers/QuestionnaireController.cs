using Company.Survey.Core.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Survey.Admin.Controllers
{
    [Authorize]
    public class QuestionnaireController : Controller
    {
        private readonly CoreContext _context;

        public QuestionnaireController(CoreContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Edit([FromRoute] int id)
        {
            var questionnaire = await _context.Surveys.Where(e => e.Id == id)
                .Include(e => e.SurveySteps.OrderBy(e => e.Order))
                    .ThenInclude(e => e.Questions.Where(e => e.ParentSurveyQuestionId == null).OrderBy(e => e.Order))
                        .ThenInclude(e => e.SurveyQuestions)
                .Include(e => e.SurveySteps.OrderBy(e => e.Order))
                    .ThenInclude(e => e.StepContent)
                        .ThenInclude(e => e.ContentBlocks)
                .FirstOrDefaultAsync();
            return View("Edit", questionnaire);
        }

        public async Task<ActionResult> NewVersion([FromRoute] int id, [FromQuery] string key)
        {
            var questionnaire = await _context.Surveys.Where(e => e.Id == id)
                .AsNoTracking()
                .Include(e => e.SurveySteps.OrderBy(e => e.Order))
                    .ThenInclude(e => e.Questions.Where(e => e.ParentSurveyQuestionId == null).OrderBy(e => e.Order))
                        .ThenInclude(e => e.SurveyQuestions)
                .Include(e => e.SurveySteps.OrderBy(e => e.Order))
                    .ThenInclude(e => e.StepContent)
                        .ThenInclude(e => e.ContentBlocks)
                .FirstOrDefaultAsync();

            var latestVersionvalue = await _context.Surveys.AsNoTracking().Where(e => e.SurveyKey == key).OrderByDescending(e => e.Version).Select(e => e.Version).FirstOrDefaultAsync();

            questionnaire.Version = ++latestVersionvalue;
            questionnaire.Id = 0;
            questionnaire.SurveySteps.ToList().ForEach(step =>
            {
                step.Id = 0;
                step.Questions.ToList().ForEach(parent =>
                {
                    parent.Id = 0;
                    parent.SurveyStep = step;
                    parent.SurveyQuestions.ToList().ForEach(child =>
                    {
                        child.Id = 0;
                        child.SurveyStep = step;
                        child.ParentSurveyQuestion = parent;
                    });
                });
                if (step.StepContent != null) 
                {
                    step.StepContent.Id = 0;
                    step.StepContent?.ContentBlocks?.ToList().ForEach(block =>
                    {
                        block.StepContent = step.StepContent;
                        block.Id = 0;
                    });
                };
            });

            await _context.AddAsync(questionnaire);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit", new { id = questionnaire.Id });
        }

        public async Task<ActionResult> DisableSurvey([FromRoute] int id)
        {
            var questionnaire = await _context.Surveys.Where(e => e.Id == id)
                .FirstOrDefaultAsync();
            _context.Remove(questionnaire);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Surveys");
        }

        // edit step (title order)
        // add new step
        // add question to step
        // remove question from step
        // edit question (title order)
        // add content to step
    }
}
