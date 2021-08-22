using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        private readonly ApiContext context;
        public PagesController(ApiContext context)
        {
            this.context = context;
        }
        //GET /api/pages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Page>>> Get()
        {
            return await context.Pages.OrderBy(x => x.Id).ToListAsync();

        }
    }
}
