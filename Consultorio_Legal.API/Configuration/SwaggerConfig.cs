using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;

namespace Consultorio_Legal.API.Configuration
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", 
                    new OpenApiInfo 
                    {
                        Title = "Consultório Legal",
                        Version = "v1",
                        Description = "API da aplicação consultório legal.",
                        Contact = new OpenApiContact
                        {
                            Name = "Gustavo Vinicius",
                            Email = "gustavoviniciusdev20@gmail.com"
                        }
                    });
            });
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => 
            {
                c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "Consultorio Legal V1");
            });


        }
    }
}