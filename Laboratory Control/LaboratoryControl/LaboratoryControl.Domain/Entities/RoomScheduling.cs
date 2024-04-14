using LaboratoryControl.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryControl.Domain.Entities;

public class RoomScheduling : EntityBase
{
    public RoomScheduling(int id, DateTime createdAt, DateTime updatedAt, DateTime? deletedAt) : base(id, createdAt, updatedAt, deletedAt)
    {
    }

    public Classroom Classroom { get; private set; }
    public DateTime SchedulingDate { get; private set; }
}
