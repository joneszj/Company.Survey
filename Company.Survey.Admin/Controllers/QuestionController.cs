using System.Linq;
using System.Threading.Tasks;
using Company.Survey.Admin.Models.Question;
using Company.Survey.Core.Data;
using Company.Survey.Core.Data.Entities;
using Company.Survey.Core.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Company.Survey.Admin.Controllers
{
    [Authorize]
    public class QuestionController : Controller
    {
        private readonly CoreContext _context;

        public QuestionController(CoreContext context) => _context = context;

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] PostQuestion postQuestion)
        {
            if (postQuestion.ParentId.HasValue)
            {
                var parent = await _context.Questions
                    .Include(e => e.SurveyQuestions.OrderBy(e => e.Order))
                    .FirstOrDefaultAsync(e => e.Id == postQuestion.ParentId.Value);
                var questions = parent.SurveyQuestions.ToArray();
                if (postQuestion.Order != -1)
                {
                    for (int i = 0; i < questions.Length; i++)
                    {
                        questions[i].Order = i;
                        if (i == postQuestion.Order) questions[i].Order = i + 1;
                    }
                }
                else
                {
                    if (questions.Length == 0) postQuestion.Order = 0;
                    else postQuestion.Order = questions.Length + 1;
                }
                parent.SurveyQuestions.Add(new SurveyQuestion
                {
                    Quesiton = postQuestion.Question,
                    Note = postQuestion.Note,
                    Order = postQuestion.Order,
                    ReplyType = (QuestionReplyTypes)postQuestion.ReplyType,
                    SurveyStepId = postQuestion.StepId
                });
            }
            else
            {
                var step = await _context.SurveySteps
                    .Include(e => e.Questions.OrderBy(e => e.Order))
                    .FirstOrDefaultAsync(e => e.Id == postQuestion.StepId);
                var questions = step.Questions.ToArray();
                if (postQuestion.Order != -1)
                {
                    for (int i = 0; i < questions.Length; i++)
                    {
                        questions[i].Order = i;
                        if (i == postQuestion.Order) questions[i].Order = i + 1;
                    }
                }
                else
                {
                    if (questions.Length == 0) postQuestion.Order = 0; 
                    else postQuestion.Order = questions.Length + 1; 
                }
                step.Questions.Add(new SurveyQuestion
                {
                    Quesiton = postQuestion.Question,
                    Note = postQuestion.Note,
                    Order = postQuestion.Order,
                    ReplyType = (QuestionReplyTypes)postQuestion.ReplyType,
                    SurveyStepId = postQuestion.StepId
                });
            }
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateOrder([FromBody] PutQuestion putQuestion)
        {
            if (putQuestion.ParentId.HasValue)
            {
                var parent = await _context.Questions.Where(e => e.Id == putQuestion.ParentId)
                    .Include(e => e.SurveyQuestions.OrderBy(e=>e.Order))
                    .FirstOrDefaultAsync();
                var questions = parent.SurveyQuestions.ToArray();
                for (int i = 0; i < questions.Length; i++)
                {
                    questions[i].Order = i;
                    if (i == putQuestion.Order) questions[i].Order = i + 1;
                }
                questions.First(e => e.Id == putQuestion.QuestionId).Order = putQuestion.Order.Value;
            }
            else
            {
                var step = await _context.SurveySteps.Where(e => e.Id == putQuestion.StepId)
                    .Include(e => e.Questions)
                    .FirstOrDefaultAsync();
                var questions = step.Questions.ToArray();
                for (int i = 0; i < questions.Length; i++)
                {
                    questions[i].Order = i;
                    if (i == putQuestion.Order) questions[i].Order = i + 1;
                }
                questions.First(e => e.Id == putQuestion.QuestionId).Order = putQuestion.Order.Value;
            }
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateText([FromBody] PutQuestion putQuestion)
        {
            var question = await _context.Questions.FindAsync(putQuestion.QuestionId);
            question.Quesiton = putQuestion.Question;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateNote([FromBody] PutQuestion putQuestion)
        {
            var question = await _context.Questions.FindAsync(putQuestion.QuestionId);
            question.Note = putQuestion.Note;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Remove([FromBody] DeleteQuestion deleteQuestion)
        {
            _context.Remove(await _context.Questions.FindAsync(deleteQuestion.QuestionId));
            _context.RemoveRange(await _context.Questions.Where(e => e.ParentSurveyQuestionId == deleteQuestion.QuestionId).ToListAsync());
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
