using GYM_System.Application.Interfaces;
using GYM_System.Application.Services;
using GYM_System.Domain.Interfaces.Repositories;
using GYM_System.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GYM_System.CrossCutting.Ioc
{
    public static class NativeInjectorBootstrap
    {
        public static void RegisterSevices(this IServiceCollection services)
        {
            services.AddScoped<ITeacherApplicationService, TeacherApplicationService>();

            services.AddScoped<ITeacherRepository, TeacherRepository>();
        }
    }
}