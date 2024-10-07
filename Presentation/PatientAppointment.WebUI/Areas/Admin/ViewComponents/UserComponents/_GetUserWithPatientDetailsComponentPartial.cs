using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.DTOs.UserDTOs;
using PatientAppointment.WebUI.Services.Interfaces;

namespace PatientAppointment.WebUI.Areas.Admin.ViewComponents.UserComponents
{
    public class _GetUserWithPatientDetailsComponentPartial : ViewComponent
    {
        private readonly IApiService<GetUserWithPatientDetailsDto> _apiService;

        public _GetUserWithPatientDetailsComponentPartial(IApiService<GetUserWithPatientDetailsDto> apiService)
        {
            _apiService = apiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _apiService.GetListAsync("User/GetUserWithPatientDetails");
            return View(values);
        }
    }
}
