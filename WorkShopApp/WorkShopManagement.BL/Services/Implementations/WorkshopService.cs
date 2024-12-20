using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.BL.DTOs.WorkshopDto;
using WorkShopManagement.BL.Services.Abstractions;
using WorkShopManagement.Core.Entities;
using WorkShopManagement.DAL.Repositories.Abstractions;

namespace WorkShopManagement.BL.Services.Implementations
{
    public class WorkshopService : IWorkshopService
    {
        private readonly IWorkshopRepository _workshopRepository;

        public WorkshopService(IWorkshopRepository workshopRepository)
        {
            _workshopRepository = workshopRepository;
        }

        public async Task<Workshop> CreateAsync(WorkshopCreateDto workshopCreateDto)
        {
           Workshop workshop = new Workshop();
            workshop.CreatedAt = DateTime.Now;
            workshop.Title = workshopCreateDto.Title;
            workshop.Description = workshopCreateDto.Description;
            workshop.Date = DateTime.Now;
            workshop.Location = workshopCreateDto.Location;
            var workshop1 = await _workshopRepository.CreateAsync(workshop);
            await _workshopRepository.SaveChangesAsync();
            return workshop1;
        }

        public async Task<ICollection<Workshop>> GetAllAsync()
        {
          return await  _workshopRepository.GetAllAsync();
        }

        public async Task<Workshop> GetByIdAsync(int id)
        {
           return await _workshopRepository.GetByIdAsync(id);
        }
    }
}
