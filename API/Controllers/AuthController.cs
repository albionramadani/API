using API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        //Post /api/auth
        [HttpPost]
        public ActionResult Login([FromBody] Login login)
        {
            if(login.Username =="admin" && login.Password == "pass")
            {
                return Json(new { succses = true });
            }
            else
            {
                return Json(new { succses = false });
            }
        }
    }
}
