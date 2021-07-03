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
    public class UniversityRepository : BaseRepository, IUniversityRepository
    {
        public UniversityRepository(AppDbContext context) : base(context)
        {

        }
        public async Task AddAsync(University university)
        {
            await _context.Universities.AddAsync(university);
        }

        public async Task<University> FindById(int id)
        {
            return await _context.Universities.FindAsync(id);
        }

        public async Task<IEnumerable<University>> ListAsync()
        {
            return await _context.Universities.ToListAsync();
        }

        public void Remove(University university)
        {
            _context.Universities.Remove(university);
        }

        public void Update(University university)
        {
            _context.Universities.Update(university);
        }
    }
}
