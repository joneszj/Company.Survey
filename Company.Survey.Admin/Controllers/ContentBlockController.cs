using System.Collections.Generic;
using System.Threading.Tasks;
using Company.Survey.Admin.Models.ContentBlock;
using Company.Survey.Core.Data;
using Company.Survey.Core.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Company.Survey.Admin.Controllers
{
    public class ContentBlockController : Controller
    {
        private readonly CoreContext _context;

        public ContentBlockController(CoreContext context) => _context = context;

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] PostContentBlock postContentBlock)
        {
            var section = await _context.StepContents.FindAsync(postContentBlock.StepContentId);
            if (section.ContentBlocks == null) section.ContentBlocks = new List<Content>();
            section.ContentBlocks.Add(new Content
            {
                ContentData = postContentBlock.Content
            });
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit", "Questionnaire", new { id = postContentBlock.SurveyId });
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] PutContentBlock putContentBlock)
        {
            var block = await _context.ConbentBlocks.FindAsync(putContentBlock.ContentBlockId);
            block.ContentData = putContentBlock.Content;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Remove([FromBody] DeleteContentBlock deleteContentBlock)
        {
            var block = await _context.ConbentBlocks.FindAsync(deleteContentBlock.ContentBlockId);
            _context.Remove(block);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
