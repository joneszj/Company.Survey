using System;
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
    public class ClientController : ControllerBase
    {
        private readonly CoreContext _context;

        public ClientController(CoreContext context) => _context = context;

        [HttpPut]
        public async Task<ActionResult> UpdateClient([FromBody] ClientViewModel clientViewModel, [FromQuery] Guid Key)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var clientSurvey = await _context.ClientSurveys.Where(e => e.ClientSurveyKey == Key)
                .Include(e=>e.Client)
                .FirstOrDefaultAsync();
            if (clientSurvey == null) return NotFound();
            var client = clientSurvey.Client;
            client.FirstName = clientViewModel.FirstName;
            client.LastName = clientViewModel.LastName;
            client.CompanyName = clientViewModel.CompanyName;
            client.Phone = clientViewModel.Phone;
            client.Email = clientViewModel.Email;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
