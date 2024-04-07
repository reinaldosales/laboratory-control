using LaboratoryControl.Domain.Abstractions;
using LaboratoryControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LaboratoryControl.Infra.Data.Repositories
{
    public class ClassroomRepository : IClassroomRepository
    {
        private readonly ApplicationDbContext _context;

        public ClassroomRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public Task Delete(Classroom classroom)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Classroom>> GetAll()
            => await _context.Classrooms
            .AsNoTracking()
            .ToListAsync();

        public Task<Classroom?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Classroom> Save(Classroom classroom)
        {
            throw new NotImplementedException();
        }

        public Task Update(Classroom classroom)
        {
            throw new NotImplementedException();
        }
    }
}
