using Company.Survey.Admin.Models;
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

            ViewBag.ClientSurveyCount = await _context.ClientSurveys.Where(e => e.SurveyId == id).CountAsync();

            return View("Edit", questionnaire);
        }


        // add new step
        // add question to step
        // remove question from step
        // edit question (title order)
        // add content to step
    }
}
