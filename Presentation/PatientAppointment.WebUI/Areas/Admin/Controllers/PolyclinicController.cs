using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.DTOs.PolyclinicDTOs;
using PatientAppointment.WebUI.Services.Interfaces;

namespace PatientAppointment.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Polyclinic")]
    public class PolyclinicController : Controller
    {
        private readonly IApiService<PolyclinicDto> _apiService;
        private readonly IApiService<CreatePolyclinicDto> _createApiService;
        private readonly IApiService<UpdatePolyclinicDto> _updateApiService;

        public PolyclinicController(IApiService<PolyclinicDto> apiService, IApiService<CreatePolyclinicDto> createApiService, IApiService<UpdatePolyclinicDto> updateApiService)
        {
            _apiService = apiService;
            _createApiService = createApiService;
            _updateApiService = updateApiService;
        }

        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            var values = await _apiService.GetListAsync("Polyclinic/");
            return View(values);
        }

        [HttpGet("Create")]
        public async Task<IActionResult> Create()
        {
            await _createApiService.GetEmpty();
            return View();
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreatePolyclinicDto createPolyclinicDto)
        {
            var value = await _createApiService.CreateItemAsync("Polyclinic/", createPolyclinicDto);
            if (value)
            {
                return Json(new { success = true, redirectUrl = Url.Action("Index", "Polyclinic", new {area = "Admin"}) });
            }
            return View(createPolyclinicDto);
        }

        [HttpGet("Update/{id}")]
        public async Task<IActionResult> Update(int id)
        {
            var value = await _updateApiService.GetItemAsync($"Polyclinic/{id}");
            return View(value);
        }

        [HttpPost("Update/{id}")]
        public async Task<IActionResult> Update(UpdatePolyclinicDto updatePolyclinicDto)
        {
            var value = await _updateApiService.UpdateItemAsync("Polyclinic/", updatePolyclinicDto);
            if (value)
            {
                return Json(new { success = true, redirectUrl = Url.Action("Index", "Polyclinic", new { area = "Admin" }) });
            }
            return View(updatePolyclinicDto);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _apiService.DeleteItemAsync($"Polyclinic/{id}");
            return Ok();
        }
    }
}
