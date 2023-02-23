using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo.mono.hexa.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificacionesController : ControllerBase
    {
        private readonly ILogger<NotificacionesController> _logger;

        public NotificacionesController(ILogger<NotificacionesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetNotification")]
        public ActionResult Index()
        {
            return StatusCode(501);
        }

        [HttpGet(Name = "GetNotificationDetail")]
        public ActionResult Details(int id)
        {
            return StatusCode(501);
        }

       

    }
}
