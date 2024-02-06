using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio_Legal.CORE.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultorio_Legal.DATA.Configuration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Enderecos>
    {
        public void Configure(EntityTypeBuilder<Enderecos> builder)
        {
           builder.HasKey(p => p.ClienteId);
        }
    }
}