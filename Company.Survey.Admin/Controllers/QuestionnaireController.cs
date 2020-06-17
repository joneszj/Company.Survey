using Company.Survey.Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Survey.Admin.Controllers
{
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
                .Include(e=>e.SurveySteps)
                    .ThenInclude(e=>e.QuestionGroups)
                .Include(e=>e.SurveySteps)
                    .ThenInclude(e=>e.Questions)
                .FirstOrDefaultAsync();
            return View("Edit", questionnaire);
        }
    }
}
