using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.DTOs.UserDTOs;
using PatientAppointment.WebUI.Services.Interfaces;


namespace PatientAppointment.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/User")]
    public class UserController : Controller
    {

        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
