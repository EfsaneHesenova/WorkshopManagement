using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkShopManagement.BL.DTOs.ParticipantDto;
using WorkShopManagement.BL.DTOs.WorkshopDto;
using WorkShopManagement.BL.Services.Abstractions;
using WorkShopManagement.BL.Services.Implementations;
using WorkShopManagement.Core.Entities;

namespace WorkShopManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkshopsController : ControllerBase
    {
        private readonly IWorkshopService _workshopService;

        public WorkshopsController(IWorkshopService workshopService)
        {
            _workshopService = workshopService;
        }
        [HttpGet]
        public async Task<ICollection<Workshop>> GetAllAsync()
        {
            return await _workshopService.GetAllAsync();
        }
        [HttpPost]
        public async Task<Workshop> CreateAsync(WorkshopCreateDto workshopCreateDto)
        {
            return await _workshopService.CreateAsync(workshopCreateDto);
        }
    }
}
