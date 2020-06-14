using Company.Survey.API.ViewModels;
using Company.Survey.Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Survey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveysController : ControllerBase
    {
        private readonly CoreContext _context;

        public SurveysController(CoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Core.Data.Entities.Survey>>> GetSurveys()
        {
            return await _context.Surveys.ToListAsync();
        }

        [HttpGet("/{email}/{userKey}")]
        public async Task<ActionResult<SurveyViewModel>> GetSurveyByClientSurveyKey(SurveyRequestViewModel surveyRequestViewModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var survey = await _context.Clients
                .Include(e => e.ClientSurveys.Where(e => e.ClientSurveyKey == surveyRequestViewModel.Key && e.Client.Email == surveyRequestViewModel.Email))
                    .ThenInclude(e => e.Survey)
                        .ThenInclude(e => e.SurveySteps)
                            .ThenInclude(e => e.Questions)
                .Include(e => e.ClientSurveys.Where(e => e.ClientSurveyKey == surveyRequestViewModel.Key && e.Client.Email == surveyRequestViewModel.Email))
                    .ThenInclude(e => e.Survey)
                        .ThenInclude(e => e.SurveySteps)
                            .ThenInclude(e => e.QuestionGroups)
                                .ThenInclude(e => e.SurveyGroupQuestions)
                .FirstOrDefaultAsync();

            if (survey == null) return NotFound();
            return Ok(new SurveyViewModel(survey.ClientSurveys.Single()));
        }

        //// PUT: api/Surveys/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSurvey(int id, Survey survey)
        //{
        //    if (id != survey.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(survey).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SurveyExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Surveys
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Survey>> PostSurvey(Survey survey)
        //{
        //    _context.Surveys.Add(survey);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSurvey", new { id = survey.Id }, survey);
        //}

        //// DELETE: api/Surveys/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Survey>> DeleteSurvey(int id)
        //{
        //    var survey = await _context.Surveys.FindAsync(id);
        //    if (survey == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Surveys.Remove(survey);
        //    await _context.SaveChangesAsync();

        //    return survey;
        //}

        private bool SurveyExists(int id)
        {
            return _context.Surveys.Any(e => e.Id == id);
        }
    }
}
