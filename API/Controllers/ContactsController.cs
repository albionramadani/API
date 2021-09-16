
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
    public class ContactsController : ControllerBase
    {
        private readonly ApiContext context;
        public ContactsController(ApiContext context)
        {
            this.context = context;
        }
        //GET /api/Contacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> Get()
        {
            return await context.Contact.OrderBy(x => x.Id).ToListAsync();

          }
        //POST /api/Contacts    
        [HttpPost]
        public async Task<ActionResult<Contact>> Create([FromForm] Contact contact)
        {

            context.Contact.Add(contact);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(Create), contact);

        }
        //Delete /api/pages
        [HttpDelete("{id}")]
        public async Task<ActionResult<Contact>> Delete(int id)
        {
            var contact = await context.Contact.FindAsync(id);
            context.Contact.Remove(contact);
            await context.SaveChangesAsync();
            return NoContent();

        }
    }
}
