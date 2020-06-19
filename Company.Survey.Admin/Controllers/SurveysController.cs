using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Company.Survey.Core.Data;
using Microsoft.AspNetCore.Authorization;

namespace Company.Survey.Admin.Controllers
{
    [Authorize]
    public class SurveysController : Controller
    {
        private readonly CoreContext _context;

        public SurveysController(CoreContext context)
        {
            _context = context;
        }

        // GET: Surveys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Surveys.ToListAsync());
        }

        // GET: Surveys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var survey = await _context.Surveys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (survey == null)
            {
                return NotFound();
            }

            return View(survey);
        }

        // GET: Surveys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Surveys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Version,CompanyName,CompanySite,ContactTitle,ContactPhone,DateOfQuestionnaire,Title,Id,CreatedBy,ModifiedBy,CreatedDate,ModifiedDate,IsActive")] Core.Data.Entities.Survey survey)
        {
            if (ModelState.IsValid)
            {
                _context.Add(survey);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(survey);
        }

        // GET: Surveys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var survey = await _context.Surveys.FindAsync(id);
            if (survey == null)
            {
                return NotFound();
            }
            return View(survey);
        }

        // POST: Surveys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Version,CompanyName,CompanySite,ContactTitle,ContactPhone,DateOfQuestionnaire,Title,Id,CreatedBy,ModifiedBy,CreatedDate,ModifiedDate,IsActive")] Core.Data.Entities.Survey survey)
        {
            if (id != survey.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(survey);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurveyExists(survey.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(survey);
        }

        // GET: Surveys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var survey = await _context.Surveys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (survey == null)
            {
                return NotFound();
            }

            return View(survey);
        }

        // POST: Surveys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var survey = await _context.Surveys.FindAsync(id);
            _context.Surveys.Remove(survey);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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

            var latestVersionvalue = await _context.Surveys.IgnoreQueryFilters().AsNoTracking().Where(e => e.SurveyKey == key).OrderByDescending(e => e.Version).Select(e => e.Version).FirstOrDefaultAsync();

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
            return RedirectToAction("Edit", "Questionnaire", new { id = questionnaire.Id });
        }

        public async Task<ActionResult> DisableSurvey([FromRoute] int id)
        {
            var questionnaire = await _context.Surveys.Where(e => e.Id == id)
                .FirstOrDefaultAsync();
            _context.Remove(questionnaire);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool SurveyExists(int id)
        {
            return _context.Surveys.Any(e => e.Id == id);
        }
    }
}
