using LaboratoryControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryControl.Application.Abstractions;

public interface IClassroomService
{
    Task<IEnumerable<Classroom>> GetAll();
    Task<Classroom> Add(Classroom classroom);
    IQueryable<Classroom> GetAllToIndex();
}
