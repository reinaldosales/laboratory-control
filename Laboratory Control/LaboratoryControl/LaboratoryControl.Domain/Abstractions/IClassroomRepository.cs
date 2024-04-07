using LaboratoryControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryControl.Domain.Abstractions;

public interface IClassroomRepository
{
    Task<IEnumerable<Classroom>> GetAll();
    Task<Classroom> Save(Classroom classroom);
    Task Delete(Classroom classroom);
    Task Update(Classroom classroom);
    Task<Classroom?> GetById(int id);
}
