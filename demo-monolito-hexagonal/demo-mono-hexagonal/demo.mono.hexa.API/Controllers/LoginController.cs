using demo.mono.dominio.login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace demo.mono.hexa.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IAuthentication _authentication;
        public LoginController(ILogger<LoginController> logger, IAuthentication authentication)
        {
            //Inyección de dependencias
            _logger = logger;
            _authentication = authentication;
        }

        // GET: Login
        [HttpGet(Name = "GetLogin")]
        [Route("GetLogin")]
        public IActionResult Index(string user, string pass)
        {
            if (string.IsNullOrEmpty(user)) 
                throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(pass))
                throw new ArgumentNullException(nameof(user));

            var token = string.Empty;
            _authentication.ValidacionLogin(user, pass, token);
            return StatusCode(200);
        }

        [HttpPost(Name = "GetLoginDetails")]
        [Route("GetLoginDetails")]
        public IActionResult Details(int id)
        {
            return StatusCode(200);
        }

 

        
    }
}
