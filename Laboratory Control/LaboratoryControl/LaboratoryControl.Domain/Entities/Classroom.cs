using LaboratoryControl.Domain.Base;

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

    public Classroom(DateTime createdAt,
        DateTime updatedAt,
        DateTime? deletedAt,
        string name) : base(createdAt, updatedAt, deletedAt)
    {
        Name = name;
    }

    public string Name { get;  set; }
}
