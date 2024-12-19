using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.Core.Entities.Base;
using WorkShopManagement.DAL.DAL;
using WorkShopManagement.DAL.Repositories.Abstractions;

namespace WorkShopManagement.DAL.Repositories.Implementations
{
    public class GenericRepository<Tentity> : IGenericRepository<Tentity> where Tentity : BaseEntity, new()
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        DbSet<Tentity> table => _context.Set<Tentity>();
        public async Task<Tentity> CreateASync(Tentity entity)
        {
          await table.AddAsync(entity);
          return entity;

        }

        public void Delete(Tentity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Tentity>> GetAllAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<Tentity> GetByIdAsync(int id)
        {
            return await table.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Tentity entity)
        {
            throw new NotImplementedException();
        }
    }
}
