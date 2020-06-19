using System.Threading.Tasks;
using Company.Survey.Core.Data;
using Microsoft.AspNetCore.Mvc;

namespace Company.Survey.Admin.Controllers
{
    public class QuestionController : Controller
    {
        private readonly CoreContext _context;

        public QuestionController(CoreContext context)
        {
            _context = context;
        }

        [HttpPut]
        public async Task<ActionResult> UpdateQuestion()
        {
            return Ok();
        }
    }
}
