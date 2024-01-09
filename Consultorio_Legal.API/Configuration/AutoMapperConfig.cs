using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio_Legal.MANAGER.Mappings;

namespace Consultorio_Legal.API.Configuration
{
    public static class AutoMapperConfig
    {
        public static void UseAutoMapperConfiguration(this IServiceCollection services)
        {
           services.AddAutoMapper(typeof(NovoClienteMappingProfile), typeof(AlteraClienteMappingProfile));
        }
    }
}