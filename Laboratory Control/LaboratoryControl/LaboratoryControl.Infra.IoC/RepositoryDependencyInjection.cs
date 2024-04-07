using LaboratoryControl.Domain.Abstractions;
using LaboratoryControl.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LaboratoryControl.Infra.IoC;

public static class RepositoryDependencyInjection
{
    public static IServiceCollection AddRepositoryDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<IClassroomRepository, ClassroomRepository>();

        return services;
    }
}
