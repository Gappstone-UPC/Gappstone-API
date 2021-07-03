using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Gappstone.API.Domain.Models;
using Gappstone.API.Domain.Persistence.Context;
using Gappstone.API.Domain.Persistence.Repositories;

namespace Gappstone.API.Persistence.Repositories
{
    public class CareerRepository : BaseRepository, ICareerRepository
    {
        public CareerRepository(AppDbContext context) : base(context)
        {

        }

        public async Task AddAsync(Career career)
        {
            await _context.Careers.AddAsync(career);
        }

        public async Task<Career> FindById(int id)
        {
            return await _context.Careers.FindAsync(id);
        }

        public async Task<IEnumerable<Career>> ListAsync()
        {
            return await _context.Careers.ToListAsync();
        }
        public void Remove(Career career)
        {
            _context.Careers.Remove(career);
        }

        public void Update(Career career)
        {
            _context.Careers.Update(career);
        }
    }
}
