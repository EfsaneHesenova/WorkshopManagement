using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.Core.Entities;
using WorkShopManagement.DAL.DAL;
using WorkShopManagement.DAL.Repositories.Abstractions;

namespace WorkShopManagement.DAL.Repositories.Implementations
{
    public class WorkshopRepository: GenericRepository<Workshop>, IWorkshopRepository
    {
        public WorkshopRepository(AppDbContext dbContext) : base(dbContext) { }
        
    }
}
