using LaboratoryControl.Application.Abstractions;
using LaboratoryControl.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryControl.Infra.IoC;

public static class ServiceDependencyInjection
{
    public static IServiceCollection AddServiceDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<IClassroomService, ClassroomService>();

        return services;
    }
}
