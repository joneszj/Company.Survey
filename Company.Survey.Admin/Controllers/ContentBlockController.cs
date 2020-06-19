using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.Survey.Core.Data;
using Microsoft.AspNetCore.Mvc;

namespace Company.Survey.Admin.Controllers
{
    public class ContentBlockController : Controller
    {
        private readonly CoreContext _context;

        public ContentBlockController(CoreContext context)
        {
            _context = context;
        }

        [HttpPut]
        public async Task<ActionResult> Update()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Add()
        {
            return Ok();
        }
    }
}
