using LaboratoryControl.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryControl.Domain.Entities;

public class Classroom : EntityBase
{
    public Classroom(
        int id,
        DateTime createdAt,
        DateTime updatedAt,
        DateTime deletedAt,
        string name) : base(id, createdAt, updatedAt, deletedAt)
    {
        Name = name;
    }

    public required string Name { get;  set; }
}
