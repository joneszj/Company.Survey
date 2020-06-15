using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.Survey.API.ViewModels;
using Company.Survey.Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.Survey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReplyController : ControllerBase
    {
        private readonly CoreContext _context;

        public ReplyController(CoreContext context) => _context = context;

        [HttpPut]
        public async Task<ActionResult> UpdateReply([FromBody] PutReplyViewModel viewModel, [FromQuery] Guid Key)
        {
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
                clientSurvey.ClientQuestionReplies.Add(new Core.Data.Entities.Reply
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
