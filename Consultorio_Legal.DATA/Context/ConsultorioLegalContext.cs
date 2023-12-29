using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio_Legal.CORE.Domain;
using Microsoft.EntityFrameworkCore;

namespace Consultorio_Legal.DATA.Context
{
    public class ConsultorioLegalContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public ConsultorioLegalContext(DbContextOptions options) : base(options)
        {
            
        }

    }
}