using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeProject.Application.Repositories;
using ResumeProject.Persistence.Contexts;
using ResumeProject.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeProject.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..\\ResumeProject.Web"));
            configurationManager.AddJsonFile("appsettings.json");

            services.AddDbContext<ResumeProjectDbContext>(options => options.UseSqlServer(configurationManager.GetConnectionString("SQLServer")));


            services.AddScoped<IAboutReadRepository, AboutReadRepository>();
            services.AddScoped<IAboutWriteRepository, AboutWriteRepository>();

            services.AddScoped<IProjectReadRepository, ProjectReadRepository>();
            services.AddScoped<IProjectWriteRepository, ProjectWriteRepository>();

            services.AddScoped<ISkillReadRepository, SkillReadRepository>();
            services.AddScoped<ISkillWriteRepository, SkillWriteRepository>();

            services.AddScoped<IServiceReadRepository, ServiceReadRepository>();
            services.AddScoped<IServiceWriteRepository, ServiceWriteRepository>();


        }
    }
}
