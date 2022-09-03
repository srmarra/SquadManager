using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"> Username do usuario</param>
        /// <param name="password">senha do usuario</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login(string username, string password)
        {
            return Ok(new { response = "Está Logado"});
        }
    }
}
