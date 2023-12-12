using Microsoft.EntityFrameworkCore;
using PCBuilderMVC.DAL.Interfaces;
using PCBuilderMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilderMVC.DAL.Repositories
{
    public class PCRepository : IBaseRepository<PC>
    {
        private readonly ApplicationDbContext _context;

        public PCRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(PC entity)
        {
            await _context.AddAsync(entity);
            return await Save();
        }

        public Task<bool> Delete(PC entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Edit(PC entity)
        {
            throw new NotImplementedException();
        }

        public async Task<PC> Get(int id)
        {
            return await _context.PCs.FirstOrDefaultAsync(pc => pc.Id == id);
        }

        public async Task<ICollection<PC>> GetAll()
        {
            return await _context.PCs.ToListAsync();
        }

        public async Task<bool> Save()
        {
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }
    }
}
