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
    public class ProductsController : ControllerBase
    {
        private readonly ApiContext context; 
        public ProductsController(ApiContext context)
        {
            this.context = context;
        }
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            return await context.Products.OrderBy(x => x.Id).ToListAsync();

        }
    }
}
