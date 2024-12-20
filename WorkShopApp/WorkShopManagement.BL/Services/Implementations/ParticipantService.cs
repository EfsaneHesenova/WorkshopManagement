using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.BL.DTOs.ParticipantDto;
using WorkShopManagement.BL.Services.Abstractions;
using WorkShopManagement.Core.Entities;
using WorkShopManagement.DAL.Repositories.Abstractions;

namespace WorkShopManagement.BL.Services.Implementations
{
    public class ParticipantService : IParticipantService
    {
        private readonly IParticipantRepository _participantRepository;

        public ParticipantService(IParticipantRepository participantRepository)
        {
            _participantRepository = participantRepository;
        }

        public async Task<Participant> CreateAsync(ParticipantCreateDto participantCreateDto)
        {
            Participant participant = new Participant();
            participant.Name = participantCreateDto.Name;
            participant.Phone = participantCreateDto.Phone;
            participant.Email = participantCreateDto.Email;
            participant.WorkshopId = participantCreateDto.WorkshopId;
            participant.CreatedAt = DateTime.Now;
            var participant1 = await _participantRepository.CreateAsync(participant);
            await _participantRepository.SaveChangesAsync();
            return participant1;
        }

        public async Task<ICollection<Participant>> GetAllAsync()
        {
           return await _participantRepository.GetAllAsync();
        }

        public async Task<Participant> GetByIdAsync(int id)
        {
            return await _participantRepository.GetByIdAsync(id);
        }
    }
}
