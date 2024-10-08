using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.DTOs.UserDTOs;
using PatientAppointment.WebUI.Services.Interfaces;

namespace PatientAppointment.WebUI.Areas.Admin.ViewComponents.UserComponents
{
    public class _GetUserWithPersonnelDetailsComponentPartial : ViewComponent
    {
        private readonly IApiService<GetUserWithPersonnelDetailsDto> _apiService;

        public _GetUserWithPersonnelDetailsComponentPartial(IApiService<GetUserWithPersonnelDetailsDto> apiService)
        {
            _apiService = apiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _apiService.GetListAsync("User/GetUserWithPersonnelDetails");
            return View(values);
        }
    }
}
