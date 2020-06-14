using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Company.Survey.Core.Data;

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

        // GET: api/Surveys
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Survey.Core.Data.Entities.Survey>>> GetSurveys()
        {
            return await _context.Surveys.ToListAsync();
        }

        // GET: api/Surveys/5
        [HttpGet("{id}/version/{version}")]
        public async Task<ActionResult<Survey.Core.Data.Entities.Survey>> GetSurvey(int id, int version)
        {
            var survey = await _context.Surveys.FindAsync(id, version);

            if (survey == null)
            {
                return NotFound();
            }

            return survey;
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
