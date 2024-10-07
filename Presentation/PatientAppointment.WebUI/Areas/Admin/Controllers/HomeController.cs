using Microsoft.AspNetCore.Mvc;

namespace PatientAppointment.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Home")]
    public class HomeController : Controller
    {
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
