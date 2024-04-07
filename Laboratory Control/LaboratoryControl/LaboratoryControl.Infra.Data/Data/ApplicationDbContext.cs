using LaboratoryControl.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LaboratoryControl.Infra.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Classroom>? Classrooms { get; set; }
    public DbSet<RoomScheduling>? RoomScheduling { get; set; }
}
