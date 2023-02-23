using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo.mono.hexa.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcesoSeleccionController : ControllerBase
    {
        private readonly ILogger<ProcesoSeleccionController> _logger;

        public ProcesoSeleccionController(ILogger<ProcesoSeleccionController> logger)
        {
            _logger = logger;
        }

        // GET: ProcesoSeleccion
        public ActionResult Index()
        {
            return StatusCode(501);
        }

        // GET: ProcesoSeleccion/Details/5
        public ActionResult Details(int id)
        {
            return StatusCode(501);
        }

        // GET: ProcesoSeleccion/Create
        public ActionResult Create()
        {
            return StatusCode(501);
        }

        // POST: ProcesoSeleccion/Create
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

        // GET: ProcesoSeleccion/Edit/5
        public ActionResult Edit(int id)
        {
            return StatusCode(501);
        }

        // POST: ProcesoSeleccion/Edit/5
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

        // GET: ProcesoSeleccion/Delete/5
        public ActionResult Delete(int id)
        {
            return StatusCode(501);
        }

        // POST: ProcesoSeleccion/Delete/5
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
