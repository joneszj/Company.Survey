using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.Survey.Core.Data;
using Microsoft.AspNetCore.Mvc;

namespace Company.Survey.Admin.Controllers
{
    public class StepContentController : Controller
    {
        private readonly CoreContext _context;

        public StepContentController(CoreContext context)
        {
            _context = context;
        }

        [HttpPut]
        public async Task<ActionResult> Update()
        {
            return Ok();
        }
    }
}
