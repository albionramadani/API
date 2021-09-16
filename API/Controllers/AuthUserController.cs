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
    public class AuthUserController : Controller
    {
        //Post /api/auth
        [HttpPost]
        public ActionResult SignIn([FromBody] SignIn signin)
        {
            if (signin.Email == "test1@test.com" && signin.Password == "test1")
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
