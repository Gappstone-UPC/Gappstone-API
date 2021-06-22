using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Persistence.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> ListAsync();
        Task<Student> FindById(int id);
        Task AddAsync(Student student);
        void Update(Student student);
        void Remove(Student student);
    }
}
