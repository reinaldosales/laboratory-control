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

        public IQueryable<Classroom> GetAllToIndex()
        {
            return _context.Classrooms;
        }

        public Task<Classroom?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Classroom> Save(Classroom classroom)
        {
            try
            {
                _context.Classrooms.Add(classroom);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }

            return classroom;
        }

        public Task Update(Classroom classroom)
        {
            throw new NotImplementedException();
        }
    }
}
