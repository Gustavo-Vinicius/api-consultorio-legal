﻿// <auto-generated />
using System;
using Consultorio_Legal.DATA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Consultorio_Legal.DATA.Migrations
{
    [DbContext(typeof(ConsultorioLegalContext))]
    partial class ConsultorioLegalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Consultorio_Legal.CORE.Domain.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Criacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Documento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(1)")
                        .HasDefaultValue("M");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Nome", "Sexo");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("Consultorio_Legal.CORE.Domain.Enderecos", b =>
                {
                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Consultorio_Legal.CORE.Domain.Telefone", b =>
                {
                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ClienteId", "Numero");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("Consultorio_Legal.CORE.Domain.Enderecos", b =>
                {
                    b.HasOne("Consultorio_Legal.CORE.Domain.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("Consultorio_Legal.CORE.Domain.Enderecos", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Consultorio_Legal.CORE.Domain.Telefone", b =>
                {
                    b.HasOne("Consultorio_Legal.CORE.Domain.Cliente", "Cliente")
                        .WithMany("Telefones")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Consultorio_Legal.CORE.Domain.Cliente", b =>
                {
                    b.Navigation("Endereco");

                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
