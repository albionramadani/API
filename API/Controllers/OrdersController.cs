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
    public class OrdersController : ControllerBase
    {
        private readonly ApiContext context;
        public OrdersController(ApiContext context)
        {
            this.context = context;
        }
        //GET /api/orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> Get()
        {
            return await context.Orders.OrderBy(x => x.Id).ToListAsync();

        }
        //POST /api/orders
        [HttpPost]
        public async Task<ActionResult<Order>> Create ([FromForm] Order order)
        {
            context.Orders.Add(order);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(Create), order);
        }
        //PUT /api/pages
        [HttpDelete("{id}")]
        public async Task<ActionResult<Page>> Delete(int id)
        {
            var order = await context.Orders.FindAsync(id);
            context.Orders.Remove(order);
            await context.SaveChangesAsync();
            return NoContent();

        }
    }
}
