using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio_Legal.DATA.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Consultorio_Legal.API.Configuration
{
    public static class DataBaseConfig
    {
        public static void AddDataBaseConfiguration (this IServiceCollection services)
        {
            services.AddDbContext<ConsultorioLegalContext>(options => options.UseSqlServer("Server=localhost; Database=DB_Consultorio_Legal; Integrated Security=True; trustServerCertificate=true"));

        }

        public static void UseDataBaseConfiguration (this IApplicationBuilder app) 
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var context = serviceScope.ServiceProvider.GetService<ConsultorioLegalContext>();
            context.Database.Migrate();
        }
    }
}