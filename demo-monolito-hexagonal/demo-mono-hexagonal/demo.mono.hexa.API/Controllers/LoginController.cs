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
        public ActionResult Index(string user, string pass)
        {
            if (string.IsNullOrEmpty(user)) 
                throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(pass))
                throw new ArgumentNullException(nameof(user));

            var token = string.Empty;
            _authentication.ValidacionLogin(user, pass, token);
            return StatusCode(200);
        }

        [HttpPost(Name = "GetLogin")]
        public ActionResult Details(int id)
        {
            return StatusCode(200);
        }

        [HttpPost(Name = "GetLogin")]
        public ActionResult Create()
        {
            return StatusCode(200);
        }

        //// POST: Login/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return StatusCode(501);
        //    }
        //    catch
        //    {
        //        return StatusCode(501);
        //    }
        //}

        //// GET: Login/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return StatusCode(501);
        //}

        //// POST: Login/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return StatusCode(501);
        //    }
        //    catch
        //    {
        //        return StatusCode(501);
        //    }
        //}

        //// GET: Login/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return StatusCode(501);
        //}

        //// POST: Login/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return StatusCode(501);
        //    }
        //    catch
        //    {
        //        return StatusCode(501);
        //    }
        //}
    }
}
