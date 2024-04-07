using LaboratoryControl.Application.Abstractions;
using LaboratoryControl.Domain.Abstractions;
using LaboratoryControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryControl.Application.Services;

public class ClassroomService : IClassroomService
{
    private readonly IClassroomRepository _classroomRepository;

    public ClassroomService(IClassroomRepository classroomRepository)
    {
        _classroomRepository = classroomRepository;
    }

    public async Task<IEnumerable<Classroom>> GetAll()
        => await _classroomRepository.GetAll();
}
