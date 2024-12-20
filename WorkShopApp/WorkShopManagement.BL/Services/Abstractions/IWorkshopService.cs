using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.BL.DTOs.ParticipantDto;
using WorkShopManagement.BL.DTOs.WorkshopDto;
using WorkShopManagement.Core.Entities;

namespace WorkShopManagement.BL.Services.Abstractions
{
    public interface IWorkshopService
    {
        Task<ICollection<Workshop>> GetAllAsync();
        Task<Workshop> CreateAsync(WorkshopCreateDto workshopCreateDto);
        Task<Workshop> GetByIdAsync(int id);
    }
}
