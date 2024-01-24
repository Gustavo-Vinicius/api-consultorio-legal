using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio_Legal.CORE.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultorio_Legal.DATA.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("Tb_Clientes");
            builder.Property(p => p.Nome).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Sexo).HasDefaultValue('M').IsRequired();
            builder.Property(p => p.Documento).HasColumnName("DocumentoIdentificador");

            builder.HasIndex(p => new { p.Nome, p.Sexo});

            builder.Property(p => p.DataNascimento).HasColumnType("varchar");
        }
    }
}