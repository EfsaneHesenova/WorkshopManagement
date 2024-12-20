using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkShopManagement.BL.DTOs.ParticipantDto;
using WorkShopManagement.BL.Services.Abstractions;
using WorkShopManagement.Core.Entities;

namespace WorkShopManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantsController : ControllerBase
    {
        private readonly IParticipantService _participantService;

        public ParticipantsController(IParticipantService participantService)
        {
            _participantService = participantService;
        }

        [HttpGet]
        public async Task<ICollection<Participant>> GetAllAsync()
        {
          return await  _participantService.GetAllAsync();
        }
        [HttpPost]
        public async Task<Participant> CreateAsync(ParticipantCreateDto participantCreateDto)
        {
          return await  _participantService.CreateAsync(participantCreateDto);
        }
    }
}
