using Microsoft.Extensions.DependencyInjection;
using MyProject.Repositories.Intefaces;
using MyProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories
{
   public static class Extention
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IChildRepository, ChildRepository>();
            return services;
        }
    }
}
