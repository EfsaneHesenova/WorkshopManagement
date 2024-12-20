using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.BL.DTOs.ParticipantDto;
using WorkShopManagement.Core.Entities;

namespace WorkShopManagement.BL.Services.Abstractions
{
    public interface IParticipantService
    {
        Task<ICollection<Participant>> GetAllAsync();
        Task<Participant> CreateAsync(ParticipantCreateDto participantCreateDto);
        Task<Participant> GetByIdAsync(int id);
        void Update(ParticipantUpdateDto participantUpdateDto);
        void Delete(ParticipantCreateDto participantCreateDto);
    }
}
