using System;
using System.Linq;
using System.Threading.Tasks;
using Company.Survey.API.ViewModels;
using Company.Survey.Core.Data;
using Company.Survey.Core.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Company.Survey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReplyController : ControllerBase
    {
        private readonly CoreContext _context;

        public ReplyController(CoreContext context) => _context = context;

        [HttpPost]
        public async Task<ActionResult<int>> CreateReply([FromBody] PutPostReplyViewModel viewModel, [FromQuery] Guid Key) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var clientsurvey = await _context.ClientSurveys.Where(e => e.ClientSurveyKey == Key)
                .Include(e=>e.ClientQuestionReplies)
                .FirstOrDefaultAsync();
            if (clientsurvey == null) return NotFound();
            var newReply = new Reply()
            {
                SurveyQuestionId = viewModel.SurveyQuestionId,
                ReplyData = viewModel.Value,
                GroupIndex = viewModel.GroupdIndex.Value
            };
            clientsurvey.ClientQuestionReplies.Add(newReply);
            await _context.SaveChangesAsync();
            return Ok(newReply.Id);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateReply([FromBody] PutPostReplyViewModel viewModel, [FromQuery] Guid Key)
        {
            // TODO: this should really be individual actions
            var clientSurvey = await _context.ClientSurveys.Where(e => e.ClientSurveyKey == Key)
                .Include(e => e.ClientQuestionReplies)
                .FirstOrDefaultAsync();
            var reply = clientSurvey.ClientQuestionReplies.FirstOrDefault(e => e.SurveyQuestionId == viewModel.SurveyQuestionId);
            if (reply != null)
            {
                reply.ReplyData = viewModel.Value;
            }
            else
            {
                clientSurvey.ClientQuestionReplies.Add(new Reply
                {
                    ReplyData = viewModel.Value,
                    SurveyQuestionId = viewModel.SurveyQuestionId
                });
            }
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
