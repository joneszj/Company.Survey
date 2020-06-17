using Company.Survey.Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Company.Survey.Admin.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly CoreContext _context;

        public QuestionnaireController(CoreContext context)
        {
            _context = context;
        }

        public ActionResult Details(int surveyId)
        {
            var questionnaire = _context.Surveys.Where(e => e.Id == surveyId)
                .Include(e=>e.SurveySteps)
                    .ThenInclude(e=>e.QuestionGroups)
                .Include(e=>e.SurveySteps)
                    .ThenInclude(e=>e.Questions);
            return View("Questionnaire/Edit", questionnaire);
        }
    }
}
