using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.DTOs.UserDTOs;
using PatientAppointment.WebUI.Services.Interfaces;

namespace PatientAppointment.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/User")]
    public class UserController : Controller
    {

        private readonly IApiService<GetUserDto> _apiService;

        public UserController(IApiService<GetUserDto> apiService)
        {
            _apiService = apiService;
        }

        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            var values = await _apiService.GetListAsync("User/");
            return View(values);
        }
    }
}
