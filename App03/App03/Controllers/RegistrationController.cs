using App03.Data;
using App03.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App03.Controllers
{
    //[Route("api/[controller]/[action]")]
    [Route("api/Registration")]
    [EnableCors("corspolicy")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly App03Context _context;

        public RegistrationController(App03Context context)
        {
            _context = context;
        }

        [Route("Register")]
        [HttpPost]
        public Register AddUser(Register obj)
        {
            _context.Register.Add(obj);
            _context.SaveChanges();

            return obj;

        }


        [HttpPost]
        [Route("LogIn")]

        public LogInModel LogIn(LogInModel obj)
        {
            var _isUserExit=_context.Register.SingleOrDefault(m=>m.Email == obj.Email && m.Password == obj.Password);
            
            if(_isUserExit != null)
            {
                obj.result = true;
                obj.message = " Looged in";
            }
            else
            {
                obj.result = false;
                obj.message = "USername or password is incorrect";
            }

            return obj;
        }
    }

}
