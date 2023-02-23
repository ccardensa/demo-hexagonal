using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo.mono.hexa.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostulanteController : ControllerBase
    {
        private readonly ILogger<PostulanteController> _logger;

        public PostulanteController(ILogger<PostulanteController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPostulante")]
        public ActionResult Index()
        {
            return StatusCode(501);
        }

        [HttpGet(Name = "GetPostulanteDetails")]
        public ActionResult Details(int id)
        {
            return StatusCode(501);
        }

        // GET: Postulante/Create
        public ActionResult Create()
        {
            return StatusCode(501);
        }

        // POST: Postulante/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return StatusCode(501);
            }
        }

        // GET: Postulante/Edit/5
        public ActionResult Edit(int id)
        {
            return StatusCode(501);
        }

        // POST: Postulante/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return StatusCode(501);
            }
        }

        // GET: Postulante/Delete/5
        public ActionResult Delete(int id)
        {
            return StatusCode(501);
        }

        // POST: Postulante/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return StatusCode(501);
            }
        }
    }
}
