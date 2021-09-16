using API.Models;
using Microsoft.AspNetCore.Identity;
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
    public class UserController : ControllerBase
    {
        private readonly ApiContext context;
        public UserController(ApiContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            return await context.Users.OrderBy(x => x.Id).ToListAsync();

        }
        //POST /api/Users
        [HttpPost]
        public async Task<ActionResult<User>> Create([FromForm] User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(Create), user);
        }
        
        //PUT /api/Users
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> Update(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            context.Entry(user).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();

        }


        //Delete /api/Users
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> Delete(int id)
        {
            var user = await context.Users.FindAsync(id);
            context.Users.Remove(user);
            await context.SaveChangesAsync();
            return NoContent();

        }
        



    }
}
